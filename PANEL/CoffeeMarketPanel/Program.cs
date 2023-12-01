
namespace CoffeeMarketPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseRouting();

            app.MapControllerRoute(
            name: "login",
            pattern: "login/{action=Login}",
            defaults: new { controller = "User" }
            );

            app.MapControllerRoute(
            name: "dashboard",
            pattern: "dashboard/{action=index}",
            defaults: new { controller = "Dashboard" }
            );


            app.MapControllers();

            app.Run();
        }
    }
}
