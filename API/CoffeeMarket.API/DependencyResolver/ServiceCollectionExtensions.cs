using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.BLL.Managers;
using CoffeeMarket.API.BLL.Services;

namespace CoffeeMarket.API.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IProductManager, ProductManager>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ITypeManager, TypeManager>();
            services.AddScoped<ITypeService, TypeService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryManager, CategoryManager>();
            services.AddScoped<IStockManager, StockManager>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderManager, OrderManager>();

            return services;
        }
    }
}
