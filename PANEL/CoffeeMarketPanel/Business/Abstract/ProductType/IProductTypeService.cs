using CoffeeMarketPanel.Models.Response.ProductType;

namespace CoffeeMarketPanel.Business.Abstract.ProductType
{
    public interface IProductTypeService
    {
        Task<List<ProductTypeResponse>> GetProductTypes();
        Task<ProductTypeResponse> GetProductType(Guid id);

    }
}
