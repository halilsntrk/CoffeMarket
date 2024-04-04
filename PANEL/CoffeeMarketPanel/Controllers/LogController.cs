using AutoWrapper.Wrappers;
using CoffeeMarketPanel.Business.Abstract.Logs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMarketPanel.Controllers
{
   
    
    public class LogController : Controller
    {
        private readonly ILogService _logService;

        public LogController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet("logs")]
        public async Task<ApiResponse> GetLogs()
        {
            var res = await _logService.GetLogs();
            return new ApiResponse { Result = res, StatusCode = 200};
        }
    }
}
