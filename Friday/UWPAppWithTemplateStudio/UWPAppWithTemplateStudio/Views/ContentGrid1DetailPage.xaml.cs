using System;

using UWPAppWithTemplateStudio.Core.Models;
using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class ContentGrid1DetailPage : Page
    {
        public ContentGrid1DetailPage()
        {
            InitializeComponent();
        }

        private ContentGrid1DetailViewModel ViewModel => DataContext as ContentGrid1DetailViewModel;
    }
}
