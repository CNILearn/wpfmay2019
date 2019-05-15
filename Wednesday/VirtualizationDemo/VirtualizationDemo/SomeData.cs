using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualizationDemo
{
    public class SomeData
    {
        public string Text { get; set; }
        public int Number { get; set; }

        public override string ToString() => Text;
    }
}
