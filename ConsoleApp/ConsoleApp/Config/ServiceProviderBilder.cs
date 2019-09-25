using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Config
{
    public class ServiceProviderBuilder
    {
        private static ServiceProviderBuilder instance;

        private ServiceProviderBuilder()
        {

        }

        public static ServiceProviderBuilder GetInstance()
        {
            if (instance == null)
            {
                if (instance == null)
                    instance = new ServiceProviderBuilder();
            }
            return instance;
        }

        public IServiceProvider GetServiceProvider()
        {
            ServiceCollection services = new ServiceCollection();
            Startup startup = new Startup();
            startup.ConfigureServices(services);
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
