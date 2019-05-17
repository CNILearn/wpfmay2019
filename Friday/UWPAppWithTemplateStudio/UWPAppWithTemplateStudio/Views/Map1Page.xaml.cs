using System;

using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class Map1Page : Page
    {
        private Map1ViewModel ViewModel => DataContext as Map1ViewModel;

        public Map1Page()
        {
            InitializeComponent();
        }
    }
}
