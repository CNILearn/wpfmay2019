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

        private void OnTabSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tabControl.IsLoaded)
            {
                
                MessageBox.Show($"selected: {tabControl.SelectedIndex}");
            }
        }
    }
}
