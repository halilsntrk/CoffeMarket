namespace CoffeeMarketPanel.DAL.Entities
{
    public class Log : BaseEntity
    {
        public string LOG_Date { get; set; }
        public string LOG_OldValue { get; set; }
        public string LOG_NewValue { get; set; }
        public string LOG_Owner { get; set; }
    }
}
