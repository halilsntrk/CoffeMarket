using CoffeeMarketPanel.Business.Abstract.Logs;
using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.DAL.Entities;
using CoffeeMarketPanel.Models.Request;
using CoffeeMarketPanel.Models.Response.Log;

namespace CoffeeMarketPanel.Business.Concrete.Logs
{
    public class LogManager : ILogService
    {
        private readonly IRepository<Log> repository;
        private readonly IHttpContextAccessor _context;

        public LogManager(IRepository<Log> repository, IHttpContextAccessor context)
        {
            this.repository = repository;
            _context = context;
        }

        public async Task<List<LogResponse>> GetLogs()
        {
            var response = new List<LogResponse>();

            try
            {
                var logs = await this.repository.GetAll();
                foreach (var log in logs)
                {
                    response.Add(new LogResponse
                    {
                        NewValue = log.LOG_NewValue,
                        OldValue = log.LOG_OldValue,
                        Owner = log.LOG_Owner,
                        Date = log.LOG_Date,

                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
           
           
          
          
            return response;
        }

        public async void Log(string user,LogRequest request)
        {
            var log = new Log
            {
                ID = Guid.NewGuid(),
                LOG_Date = DateTime.Now.ToString(),
                LOG_NewValue = request.NewValue,
                LOG_OldValue = request.OldValue,
                LOG_Owner = user,
            };
            await this.repository.Create(log);
        }
    }
}
