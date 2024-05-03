using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Entities
{
    public class User 
    {
        public Guid ID { get; set; }
        public string USR_Username { get; set; }
        public string USR_Password { get; set; }
        public int USR_Validation { get; set; }
        public string USR_Token { get; set; }
        public int USR_Status { get; set; }
    }
}
