using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new GreetingController();
            var result = controller.Hello("Stephanie");
            Console.WriteLine(result);
        }
    }
}
