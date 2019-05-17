using System;

using UWPAppWithTemplateStudio.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.Views
{
    public sealed partial class Chart1Page : Page
    {
        private Chart1ViewModel ViewModel => DataContext as Chart1ViewModel;

        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public Chart1Page()
        {
            InitializeComponent();
        }
    }
}
