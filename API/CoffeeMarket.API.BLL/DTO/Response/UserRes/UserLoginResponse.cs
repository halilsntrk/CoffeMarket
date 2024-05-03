using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMarket.API.BLL.DTO.Response.UserRes
{
    public class UserLoginResponse
    {
        public string username { get; set; }
        public string token { get; set; }
        public int validation { get; set; }
    }
}
