using System;

using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class ContentGrid1Page : Page
    {
        private ContentGrid1ViewModel ViewModel => DataContext as ContentGrid1ViewModel;

        public ContentGrid1Page()
        {
            InitializeComponent();
        }
    }
}
