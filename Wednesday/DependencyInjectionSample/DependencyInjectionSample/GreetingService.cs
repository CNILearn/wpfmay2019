using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class GreetingService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
