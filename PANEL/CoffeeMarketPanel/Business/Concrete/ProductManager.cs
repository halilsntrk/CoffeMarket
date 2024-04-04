using CoffeeMarketPanel.Business.Abstract.Logs;
using CoffeeMarketPanel.Business.Abstract.Product;
using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.DAL.Entities;
using CoffeeMarketPanel.Helpers;
using CoffeeMarketPanel.Models.GeneralResponse;
using CoffeeMarketPanel.Models.Request;
using CoffeeMarketPanel.Models.Response.Product;
using Newtonsoft.Json;

namespace CoffeeMarketPanel.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly IRepository<ProductType> _typerepository;
        private readonly IRepository<_Stock> _stockrepository;
        private readonly ILogService _log;


        private string apiUrl = "https://localhost:44387/";

        public ProductManager(IRepository<Product> repository, IRepository<ProductType> typerepository, IRepository<_Stock> stockrepository, ILogService log)
        {
            _repository = repository;
            _typerepository = typerepository;
            _stockrepository = stockrepository;
            _log = log;
        }

        public async Task<ApiResponse<ProductResponse>> Create(ProductRequest req)
        {
            
            Product product = new()
            {
                ID = Guid.NewGuid(),
                PR_Grammage = req.Grammage.ToString(),
                PR_Name = req.Name,
                PR_Price = req.Price.ToString(),
                PR_ProductID = Guid.NewGuid().ToString(),
                PR_SpotDetail = req.Spot,
                PR_TypeID = req.TypeID,
                PR_Status = 1
            };
            product.PR_DetailImage = new Models.Common.Image(req.DetailImage).imageURL;
            product.PR_ListImage = new Models.Common.Image(req.ListImage).imageURL;

            var res = await _repository.Create(product);

            if (res)
            {

                var log_string = JsonConvert.SerializeObject(product);
                _log.Log(GeneralHelper.getUserName(), new LogRequest { NewValue = log_string, OldValue = "" });
                return new ApiResponse<ProductResponse>()
                {
                    data = new ProductResponse(),
                    status = "true",
                    message = "Ürün eklendi"
                };
            }


            return new ApiResponse<ProductResponse>()
            {
                data = new ProductResponse(),
                status = "false",
                message = "Ürün eklenmedi"
            };
        }

        public async Task<ApiResponse<bool>> Delete(Guid id)
        {
            var product = await _repository.GetById(id);
            if (product != null)
            {
                var result = await _repository.Delete(product);
                if (!result)
                {
                    return new ApiResponse<bool> { status = "false", data = false, message = "Ürün silinemedi" };
                }

                return new ApiResponse<bool> { status = "true", data = true, message = "Ürün silindi" };
            }
            return new ApiResponse<bool> { status = "true", data = true, message = "Ürün bulunamadı" };
        }

        public async Task<ApiResponse<ProductResponse>> GetProductById(Guid id)
        {
            var product = await _repository.GetById(id);
            if (product != null)
            {
                var productresponse = new ProductResponse()
                {
                    id = product.ID,
                    grammage = product.PR_Grammage,
                    imageurl = product.PR_ListImage,
                    name = product.PR_Name,
                    price = product.PR_Price,

                };

                var stock = _stockrepository.GetById(product.ID).Result.Stock;
                productresponse.stock = stock.ToString();

                productresponse.type = _typerepository.GetById(Guid.Parse(product.PR_TypeID)).Result.TypeName;

                return new ApiResponse<ProductResponse> { status = "true", data = productresponse };
            }
            return new ApiResponse<ProductResponse> { status = "false", message = "Ürün bulunamadı" };
        }

        public async Task<List<ProductResponse>> GetProducts()
        {
            List<ProductResponse> products = new();
            var response = await _repository.GetAll();

            if (response != null)
            {
                foreach (var product in response)
                {

                    var producttype = await _typerepository.GetById(Guid.Parse(product.PR_TypeID));
                    var productstock = await _stockrepository.GetById(product.ID) ?? new _Stock();
                    var productResponse = new ProductResponse()
                    {
                        id = product.ID,
                        name = product.PR_Name,
                        price = product.PR_Price,
                        grammage = product.PR_Grammage,
                        type = producttype.TypeName,
                        imageurl = apiUrl + product.PR_ListImage,
                        stock = productstock.Quantity.ToString()


                    };
                    products.Add(productResponse);

                }

            }

            return products;
        }

        public async Task<ApiResponse<bool>> Update(ProductUpdateRequest req)
        {
            var product = await _repository.GetById(req.ID);
            var response = new ApiResponse<bool>();
            if (req.Quantity != null)
            {
                var stock = await _stockrepository.GetById(req.ID);
                stock.Quantity = int.Parse(req.Quantity);
                stock.Stock = int.Parse(req.Quantity) * stock.Grammage;
                response.data = await _stockrepository.Update(stock);
                response.message = "Stok Güncellendi";
            }
            if (req.Price != null)
            {
                product.PR_Price = req.Price;
                response.data = await _repository.Update(product);
                response.message = "Ürün Fiyatı Güncellendi";
            }

            return response;

        }
    }
}
