using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class Camera1Page : Page
    {
        private Camera1ViewModel ViewModel => DataContext as Camera1ViewModel;

        public Camera1Page()
        {
            InitializeComponent();
            ViewModel.Initialize(cameraControl);
        }
    }
}
