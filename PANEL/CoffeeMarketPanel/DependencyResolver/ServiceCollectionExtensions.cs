using CoffeeMarketPanel.Business.Abstract.Logs;
using CoffeeMarketPanel.Business.Abstract.Product;
using CoffeeMarketPanel.Business.Abstract.ProductType;
using CoffeeMarketPanel.Business.Abstract.User;
using CoffeeMarketPanel.Business.Concrete;
using CoffeeMarketPanel.Business.Concrete._User;
using CoffeeMarketPanel.Business.Concrete.Logs;
using CoffeeMarketPanel.DAL;
using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.DAL.Concrete;
using Microsoft.Extensions.Options;

namespace CoffeeMarketPanel.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductTypeService, ProductTypeManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<ILogService, LogManager>();
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddDbContext<CoffeeMarketDbContext>();
            return services;
        }
    }
}
