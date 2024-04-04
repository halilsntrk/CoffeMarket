using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.Models.GeneralResponse;
using CoffeeMarketPanel.Models.Request;

namespace CoffeeMarketPanel.Business.Abstract.User
{
    public interface IUserService
    {
        Task<ApiResponse<string>> Create(UserLoginRequest user);
        Task<ApiResponse<string>> Login(UserLoginRequest user);
    }
}
