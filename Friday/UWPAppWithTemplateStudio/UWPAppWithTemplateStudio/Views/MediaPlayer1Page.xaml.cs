using System;

using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class MediaPlayer1Page : Page
    {
        private MediaPlayer1ViewModel ViewModel => DataContext as MediaPlayer1ViewModel;

        public MediaPlayer1Page()
        {
            InitializeComponent();
            ViewModel.Initialize(mpe);
        }
    }
}
