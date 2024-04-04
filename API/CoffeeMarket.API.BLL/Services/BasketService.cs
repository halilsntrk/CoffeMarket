using CoffeeMarket.API.BLL.Interfaces.Services;
using CoffeMarket.API.DAL.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Services
{
    public class BasketService : DbFactoryBase, IBasketService
    {
        public BasketService(IConfiguration configuration) : base(configuration)
        {
        }
    }
}
