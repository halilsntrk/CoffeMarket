using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMarket.API.DAL.Entities
{
    public class Basket
    {
        public Guid ID { get; set; }
        public Guid USR_ID { get; set; }
        public string BSK_Products { get; set; }
        public int Status { get; set; }
    }
}
