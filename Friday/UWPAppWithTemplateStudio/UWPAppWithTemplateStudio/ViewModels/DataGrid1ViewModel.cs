using System.Collections.ObjectModel;

using Prism.Windows.Mvvm;

using UWPAppWithTemplateStudio.Core.Models;
using UWPAppWithTemplateStudio.Core.Services;

namespace UWPAppWithTemplateStudio.ViewModels
{
    public class DataGrid1ViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public DataGrid1ViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<SampleOrder> Source => _sampleDataService.GetGridSampleData();
    }
}
