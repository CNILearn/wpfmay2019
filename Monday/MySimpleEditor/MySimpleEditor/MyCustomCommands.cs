using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MySimpleEditor
{
    public class MyCustomCommands
    {
        private static ICommand s_action1Command;
        public static ICommand Action1Command
        {
            get => s_action1Command ?? (s_action1Command = new RoutedUICommand("Action1", "Action1", typeof(MyCustomCommands)));
        }
    }
}
