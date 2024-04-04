using CoffeeMarketPanel.Business.Abstract.ProductType;
using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.DAL.Entities;
using CoffeeMarketPanel.Models.Response.ProductType;

namespace CoffeeMarketPanel.Business.Concrete
{
    public class ProductTypeManager : IProductTypeService
    {
        private readonly IRepository<ProductType> _repository;

        public ProductTypeManager(IRepository<ProductType> repository)
        {
            _repository = repository;
        }

        public async Task<ProductTypeResponse> GetProductType(Guid id)
        {
            ProductTypeResponse productTypeResponse = new ProductTypeResponse();
           var response =  await _repository.GetById(id);
            if (response != null)
            {

                productTypeResponse.typename = response.TypeName;
                

                return productTypeResponse;
            }

            return productTypeResponse;
        }

        public async Task<List<ProductTypeResponse>> GetProductTypes()
        {
            List<ProductTypeResponse > products = new List<ProductTypeResponse>();
            var response = await _repository.GetAll();

            if (response !=null)
            {
                foreach (var types in response)
                {
                    products.Add(new ProductTypeResponse { typename = types.TypeName, id = types.ID });
                }

                return products;
            }

            return products;
        }
    }
}
