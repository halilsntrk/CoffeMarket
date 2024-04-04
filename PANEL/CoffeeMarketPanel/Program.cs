using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using CoffeeMarketPanel.DependencyResolver;
using CoffeeMarketPanel.AppData;
using Treblle.Net.Core;

namespace CoffeeMarketPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = "https://myapp.com",
                ValidAudience = "https://api.myapp.com",
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("128693741253128693741253128693741253"))
            };

        });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAny", builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });
            builder.Services.AddMyDependencyGroup();
            builder.Services.AddTreblle("beNEFL1le92DR76jjULlqV8Wzj9j0ddu", "QV2rNXQKq5Ju0071");
            builder.Services.AddDataProtection();
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseTreblle(useExceptionHandler: true);
            app.UseHttpsRedirection();
            app.UseSession();
            app.Routes();
            app.UseCors(x => x
      .AllowAnyOrigin()
      .AllowAnyMethod()
      .AllowAnyHeader());
            app.UseAuthentication();
            app.UseAuthorization();
            app.Run();
        }
    }
}
