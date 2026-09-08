using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boraler_api.config
{
    public class Startup(IConfiguration configuration)
    {
        private IConfiguration Configuration { get; } = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOpenApi();
        } 
    }
}