using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationSample
{
    public class SomeData : IDataErrorInfo
    {
        private int _value1;

        public int Value1
        {
            get => _value1;
            set
            {
                if (value > 50)
                    throw new Exception("bad value");
                _value1 = value;
            }
        }

        public int Value2 { get; set; }

        public string this[string columnName]
        {
            get
            {
                string error = null;
                switch (columnName)
                {
                    case "Value2":
                        if (Value2 > 50) error = "bad value in Value2";
                        break;
                    default:
                        break;
                }
                return error;
            }
        }

        public string Error => throw new NotImplementedException();
    }
}
