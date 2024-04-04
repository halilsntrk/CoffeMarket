namespace CoffeeMarketPanel.DAL.Entities
{
    public class User : BaseEntity
    {
        public string USR_Username { get; set; }
        public string USR_Password { get; set; }
        public int? USR_Validation { get; set; }
        public string? USR_Token { get; set; }
        public int USR_Status { get; set; }
    }
}
