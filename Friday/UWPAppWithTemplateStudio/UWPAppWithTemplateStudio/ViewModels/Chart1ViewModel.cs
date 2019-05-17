using System;
using System.Collections.ObjectModel;

using Prism.Windows.Mvvm;

using UWPAppWithTemplateStudio.Core.Models;
using UWPAppWithTemplateStudio.Core.Services;

namespace UWPAppWithTemplateStudio.ViewModels
{
    public class Chart1ViewModel : ViewModelBase
    {
        private readonly ISampleDataService _sampleDataService;

        public Chart1ViewModel(ISampleDataService sampleDataServiceInstance)
        {
            _sampleDataService = sampleDataServiceInstance;
        }

        public ObservableCollection<DataPoint> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return _sampleDataService.GetChartSampleData();
            }
        }
    }
}
