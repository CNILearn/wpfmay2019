using System;

using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class ImageGallery1Page : Page
    {
        private ImageGallery1ViewModel ViewModel => DataContext as ImageGallery1ViewModel;

        public ImageGallery1Page()
        {
            InitializeComponent();
        }
    }
}
