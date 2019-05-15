using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = RegisterServices();

            var controller = container.GetService<GreetingController>();
            var result = controller.Hello("Katharina");
            Console.WriteLine(result);
        }

        static IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IGreetingService, GreetingService>();
            services.AddTransient<GreetingController>();
            return services.BuildServiceProvider();
        }
    }
}
