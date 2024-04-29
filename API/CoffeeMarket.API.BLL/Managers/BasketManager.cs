using CoffeeMarket.API.BLL.Interfaces.Managers;
using CoffeeMarket.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Managers
{
    public class BasketManager : IBasketManager
    {
        public async Task<bool> AddToBasket(ProductToBasket product)
        {
            
            throw new NotImplementedException();
        }

        public async Task<bool> CreateBasket(string token)
        {

            return  true;
        }
    }
}
