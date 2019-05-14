using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CursorChangeSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public IEnumerable<string> CursorNames => Enum.GetNames(typeof(CursorType));
        public string SelectedCursorName { get; set; }

        private Cursor _prevCursor;
        private void OnMouseEnter(object sender, MouseEventArgs e)
        { 
            Type cursorsType = typeof(Cursors);
            if (!string.IsNullOrEmpty(SelectedCursorName))
            {
                var cursor = cursorsType.InvokeMember(SelectedCursorName, BindingFlags.GetProperty, null, null, null);
                _prevCursor = this.Cursor;
                if (cursor is Cursor newCursor)
                {
                    this.Cursor = newCursor;
                }
            }
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            this.Cursor = _prevCursor;
            _prevCursor = null;
        }
    }
}
