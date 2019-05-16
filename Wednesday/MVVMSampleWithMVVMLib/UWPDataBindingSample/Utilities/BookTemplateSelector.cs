using DataBindingSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPDataBindingSample.Utilities
{
    public class BookTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultBookTemplate { get; set; }
        public DataTemplate WroxBookTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
            => item switch
               {
                   Book { Publisher: "Wrox Press" } => WroxBookTemplate,
                   Book _ => DefaultBookTemplate,
                   _ => null
               };
    }
}
