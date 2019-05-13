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

namespace MyFirstWPFApp
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

        private void OnButtonClick(object sender, RoutedEventArgs e)
        { 
            Grid.SetRow(button1, 2);
        }





        private void OnInnerButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;  // do not bubble
            MessageBox.Show("inner button click");
        }

        private void OnButtonClickInGrid(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("button click in grid");
        }
    }
}
