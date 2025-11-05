using GroupProject.Data;
using GroupProject.Data.RespositoryServices;

namespace GroupProject.DI
{
    public static class LifeTimeServices
    {
        public static IServiceCollection DIServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();

            //add swagger service
            services.AddSwaggerGen();


            services.AddScoped<IProduct, ProductServices>();
            return services;
        }
    }
}
