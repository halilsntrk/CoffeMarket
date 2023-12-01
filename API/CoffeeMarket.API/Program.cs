using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.BLL.Managers;
using CoffeeMarket.API.BLL.Services;
using Microsoft.Extensions.FileProviders;

namespace CoffeeMarket.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
	
			builder.Services.AddScoped<IProductManager, ProductManager>();
			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<ITypeManager, TypeManager>();
			builder.Services.AddScoped<ITypeService, TypeService>();
			builder.Services.AddScoped<ICategoryService, CategoryService>();
			builder.Services.AddScoped<ICategoryManager, CategoryManager>();
			builder.Services.AddScoped<IStockManager, StockManager>();
			builder.Services.AddScoped<IStockService, StockService>();
			builder.Services.AddScoped<IOrderService, OrderService>();
			builder.Services.AddScoped<IOrderManager, OrderManager>();

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();
			app.UseCors(x => x
		   .AllowAnyOrigin()
		   .AllowAnyMethod()
		   .AllowAnyHeader());
			app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/uploads",
                FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "uploads/"))
            });
            app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}