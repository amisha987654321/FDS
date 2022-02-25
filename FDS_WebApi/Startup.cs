using FDS.BusinessLogic;

namespace FDS_WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            IocConfig.ConfigureServices(ref services);
        }
    }
}
