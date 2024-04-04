using CoffeeMarketPanel.Business.Abstract.User;
using CoffeeMarketPanel.DAL.Abstract;
using CoffeeMarketPanel.DAL.Entities;
using CoffeeMarketPanel.Helpers;
using CoffeeMarketPanel.Models.GeneralResponse;
using CoffeeMarketPanel.Models.Request;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoffeeMarketPanel.Business.Concrete._User
{
    public class UserManager : IUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IConfiguration _configuration;
        private readonly IDataProtectionProvider _dataProtectionProvider;
        private  IHttpContextAccessor _context;
        public UserManager(IRepository<User> repository, IConfiguration configuration, IDataProtectionProvider dataProtectionProvider, IHttpContextAccessor context)
        {
            _repository = repository;
            _configuration = configuration;
            _dataProtectionProvider = dataProtectionProvider;
            _context = context;
        }

        public async Task<ApiResponse<string>> Create(UserLoginRequest user)
        {
            var cryptedpassword = new GeneralHelper(_dataProtectionProvider, _configuration).Encrypt(user.password);
            user.password = cryptedpassword;

          var res = await  _repository.Create(new User
            {
                ID = Guid.NewGuid(),
                USR_Password = cryptedpassword,
                USR_Status = 1,
                USR_Username = user.username,
                USR_Validation = 1,
            });

            if (res)
            {
                return new ApiResponse<string> { status = "true"};
            }
            return new ApiResponse<string> { status = "false" };
        }

        public async Task<ApiResponse<string>> Login(UserLoginRequest user)
        {
            var table = await _repository.Table();
            var cryptedpass = new GeneralHelper(_dataProtectionProvider,_configuration).Encrypt(user.password);
            var user_ = table.Where(x => x.USR_Username == user.username && x.USR_Password == cryptedpass).FirstOrDefault();
            if (user_ != null)
            {
                  var token = GenerateToken(user_.USR_Username);
                user_.USR_Token = token;
                user_.USR_Validation = 1;


                try
                {
                    await _repository.Update(user_);
                    return new ApiResponse<string> {status = "true", data = token, message = "Giriş başarılı" };
                }
                catch (Exception)
                {

                    throw;
                }
              
               

            }
            return new ApiResponse<string> { status = "false", data = null, message = "Kullanıcı bulunamadı" };

        }



        private string GenerateToken(string username)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("128693741253128693741253128693741253"));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Role,"admin"),
        new Claim(JwtRegisteredClaimNames.Sub, username),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
    };

            var token = new JwtSecurityToken(
                issuer: "https://myapp.com",
                audience: "https://api.myapp.com",
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(30),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
