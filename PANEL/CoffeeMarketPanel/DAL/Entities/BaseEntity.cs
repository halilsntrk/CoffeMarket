using System.ComponentModel.DataAnnotations;

namespace CoffeeMarketPanel.DAL.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid ID { get; set; }
    }
}
