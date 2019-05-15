using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class GreetingController
    {
        private readonly IGreetingService _greetingService;
        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService ?? throw new ArgumentNullException(nameof(greetingService));
        }

        public string Hello(string name)
        {
            string result = _greetingService.Greet(name);
            return result.ToUpper();
        }
    }
}
