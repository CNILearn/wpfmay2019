using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class GreetingController
    {
        public string Hello(string name)
        {
            var service = new GreetingService();
            string result = service.Greet(name);
            return result.ToUpper();
        }
    }
}
