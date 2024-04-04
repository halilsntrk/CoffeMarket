
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeMarketPanel.DAL.Entities
{
	public class Product :BaseEntity
	{

        
        public string? PR_ProductID { get; set; }
        public string? PR_TypeID { get; set; }
        public string? PR_Name { get; set; }
        public string? PR_Grammage { get; set; }
        public string? PR_Price { get; set; }
        public string? PR_ListImage { get; set; }
        public string? PR_DetailImage { get; set; }
        public string? PR_SpotDetail { get; set; }
        public int PR_Status { get; set; }

    }
}
