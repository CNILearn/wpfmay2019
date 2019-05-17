using System;

using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class ImageGallery1DetailPage : Page
    {
        public ImageGallery1DetailViewModel ViewModel => DataContext as ImageGallery1DetailViewModel;

        public ImageGallery1DetailPage()
        {
            InitializeComponent();
        }

        private void OnPageKeyDown(object sender, KeyRoutedEventArgs e)
        {
            ViewModel.HandleKeyDown(e);
        }
    }
}
