using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeeMarket.API.BLL.Managers;
using CoffeeMarket.API.BLL.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL
{
	public static class BLLServiceConfiguration
	{
		public static IServiceCollection AddBLLServices(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddScoped<ICoffeeService, CoffeService>();

			return services;
		}

	}
}
