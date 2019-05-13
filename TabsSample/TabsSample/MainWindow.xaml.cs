using System.Windows;
using System.Windows.Controls;

namespace TabsSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool _isInitialized = false;
        private void OnTabSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
            }
            else
            {
                MessageBox.Show("test");
            }
        }
    }
}
