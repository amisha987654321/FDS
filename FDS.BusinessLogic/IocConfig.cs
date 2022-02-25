using FDS.BusinessLogic.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace FDS.BusinessLogic
{
    public static class IocConfig
    {
        public static void ConfigureServices(ref IServiceCollection service)
        {
            service.AddTransient<ICustomerManager, CustomerManager>();
            service.AddTransient<IRestaurantManager, RestaurantManager>();
            service.AddTransient<IAddressManager, AddressManager>();

            FDS.DataAccess.IocConfig.ConfigureServices(ref service);
        }
    }
}
