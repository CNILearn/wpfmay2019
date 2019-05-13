using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ShapesSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnChangeShape(object sender, RoutedEventArgs e)
        {
            SetMouth();
        }



        private bool _laugh = false;

        private void SetMouth()
        {
            if (_laugh)
            {
                mouth.Data = Geometry.Parse("M 30,60 Q 50,65 70,60");
            }
            else
            {
                mouth.Data = Geometry.Parse("M 30,60 Q 50,90 70,60");
            }
            _laugh = !_laugh;
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            SetMouth();
        }

        private void OnEllipseButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mouse button down");
        }
    }
}
