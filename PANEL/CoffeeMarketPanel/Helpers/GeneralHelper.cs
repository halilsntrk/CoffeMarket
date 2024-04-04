using CoffeeMarketPanel.DAL.Entities;
using CoffeeMarketPanel.Models.Request;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography;
using System.Text;

namespace CoffeeMarketPanel.Helpers
{
    public class GeneralHelper
    {
        private readonly IDataProtectionProvider _provider;
        private readonly IConfiguration _configuration;

        HttpContextAccessor accessor = new();
        public static string KEY = "";
        public GeneralHelper(IDataProtectionProvider provider, IConfiguration configuration)
        {
            _provider = provider;
            _configuration = configuration;
         
        }

        public string Encrypt(string password)
        {
            KEY = _configuration.GetSection("ProtectorKey").Value ?? string.Empty;
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(KEY, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return password;
        }

        public string Decrypt(string encryptedpass)
        {
            KEY = _configuration.GetSection("ProtectorKey").Value ?? string.Empty;
            byte[] cipherBytes = Convert.FromBase64String(encryptedpass);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(KEY, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    encryptedpass = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return encryptedpass;
        }

       public static string getUserName()
        {
            var token = new HttpContextAccessor().HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();

            var tokenDecode = handler.ReadJwtToken(token);
            var username = tokenDecode.Claims.First(claim => claim.Type == JwtRegisteredClaimNames.Sub).Value;
            return username;
        }
    }
}
