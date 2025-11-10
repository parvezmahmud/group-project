using GroupProject.Data;
using GroupProject.Data.RespositoryServices;
using System.Text.Json.Serialization;

namespace GroupProject.DI
{
    internal static class LifeTimeServices
    {
        internal static IServiceCollection DIServices(this IServiceCollection services)
        {
            services.AddControllers().AddJsonOptions(options=>options.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles);
            services.AddEndpointsApiExplorer();

            //add swagger service
            services.AddSwaggerGen();


            services.AddScoped<IProduct, ProductServices>();
            return services;
        }
    }
}
