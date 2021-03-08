using Microsoft.Extensions.Configuration;

namespace Nordware.ServiceLayer.Bridge.API.Models
{
    public class AppSettingsModel
    {
        private readonly IConfiguration Configuration;

        public AppSettingsModel(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ServiceLayerConnection ServiceLayerConnection { get; set; }
    }

    public class ServiceLayerConnection
    {
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CompanyDB { get; set; }
    }
}
