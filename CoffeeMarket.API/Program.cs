using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.BLL.Managers;
using CoffeeMarket.API.BLL.Services;

namespace CoffeeMarket.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
	
			builder.Services.AddScoped<ICoffeeManager, CoffeManager>();
			builder.Services.AddScoped<ICoffeeService, CoffeService>();
			builder.Services.AddScoped<ITypeManager, TypeManager>();
			builder.Services.AddScoped<ITypeService, TypeService>();
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

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}