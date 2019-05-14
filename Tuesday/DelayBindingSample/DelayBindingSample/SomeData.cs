using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelayBindingSample
{
    public class SomeData
    {
        private string _data1;

        public string Data1
        {
            get { return _data1; }
            set
            {
                _data1Values.Add(value);
                _data1 = value;
            }
        }
        private string _data2;

        public string Data2
        {
            get { return _data2; }
            set { _data2 = value; }
        }

        private ObservableCollection<string> _data1Values = new ObservableCollection<string>();
        public IEnumerable<string> Data1Values => _data1Values;
    }
}
