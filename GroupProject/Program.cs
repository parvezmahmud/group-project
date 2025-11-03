using GroupProject.Data;
using Microsoft.EntityFrameworkCore;

namespace GroupProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Add controller services
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContextPool<ApplicationDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("Default")));



            //add swagger service
            builder.Services.AddSwaggerGen();

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
