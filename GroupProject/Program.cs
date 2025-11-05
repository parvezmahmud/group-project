using GroupProject.Data;
using GroupProject.Data.RespositoryServices;
using GroupProject.DI;
using Microsoft.EntityFrameworkCore;

namespace GroupProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add controller services
            builder.Services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")));

            // Services
            builder.Services.DIServices();

            var app = builder.Build();

            //add swagger
            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapControllers();
            app.Run();
        }
    }
}
