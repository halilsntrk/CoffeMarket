namespace CoffeeMarketPanel.Models.GeneralResponse
{
    public class ApiResponse<T> 
    {
        public string message { get; set; }
        public string status { get; set; }
        public T data { get; set; }

       
    }

}
