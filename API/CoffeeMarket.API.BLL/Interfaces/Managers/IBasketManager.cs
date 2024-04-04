using CoffeeMarket.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.Interfaces.Managers
{
    public interface IBasketManager
    {
        Task<bool> CreateBasket(string token);
        Task<bool> AddToBasket(ProductToBasket product);
    }
}
