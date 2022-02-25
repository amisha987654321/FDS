using FDS.DataAccess.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace FDS.DataAccess
{
    public static class IocConfig
    {
        public static void ConfigureServices(ref IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<IAddressRepository, AddressRepository>();
        }        
    }
}
