using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new GreetingController(new GreetingService());
            var result = controller.Hello("Matthias");
            Console.WriteLine(result);
        }
    }
}
