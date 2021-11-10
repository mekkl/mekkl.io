using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace mekkl.Presentation.ConsoleApp
{
    class Program
    {
        private static ServiceProvider _serviceProvider;
        private static string _env = "Development";

        static void Main(string[] args)
        {
            RegisterServices();
            IServiceScope scope = _serviceProvider.CreateScope();
            Console.Write("Hello WOrld");
        }
        
        private static void RegisterServices()
        {
            var services = new ServiceCollection();

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{_env}.json", true, true)
                .Build();
            
            services.AddSingleton(config); 
            
            _serviceProvider = services.BuildServiceProvider(true);
        }
    }
}
