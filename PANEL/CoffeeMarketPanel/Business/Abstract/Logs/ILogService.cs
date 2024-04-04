using CoffeeMarketPanel.Models.Request;
using CoffeeMarketPanel.Models.Response.Log;
using Microsoft.AspNetCore.Identity.Data;

namespace CoffeeMarketPanel.Business.Abstract.Logs
{
    public interface ILogService 
    {
        void Log(string user ,LogRequest request);
        Task<List<LogResponse>> GetLogs();
    }
}
