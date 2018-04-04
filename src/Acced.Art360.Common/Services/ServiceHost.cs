using Microsoft.AspNetCore.Hosting;

namespace Acced.Art360.Services
{
    public class ServiceHost : IServiceHost
    {
        private readonly IWebHost _webHost;

        public ServiceHost(IWebHost webHost)
        {
            _webHost = webHost;
        }

        void IServiceHost.Run() => _webHost.Run(); 
    }
}