using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Request.User
{
    public class UserCreateRequest
    {
        public string username { get; set; }
        public string password   { get; set; }
    }
}
