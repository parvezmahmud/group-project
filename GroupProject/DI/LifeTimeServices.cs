using GroupProject.Data;
using GroupProject.Data.RespositoryServices;

namespace GroupProject.DI
{
    internal static class LifeTimeServices
    {
        internal static IServiceCollection DIServices(this IServiceCollection services)
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
