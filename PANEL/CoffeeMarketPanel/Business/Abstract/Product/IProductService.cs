using CoffeeMarketPanel.Models.GeneralResponse;
using CoffeeMarketPanel.Models.Request;
using CoffeeMarketPanel.Models.Response.Product;

namespace CoffeeMarketPanel.Business.Abstract.Product
{
    public interface IProductService
    {
        Task<List<ProductResponse>> GetProducts();
        Task<ApiResponse<ProductResponse>> GetProductById(Guid id);
        Task<ApiResponse<ProductResponse>> Create(ProductRequest req);
        Task<ApiResponse<bool>> Update(ProductUpdateRequest req);
        Task<ApiResponse<bool>> Delete(Guid id);
    }
}
