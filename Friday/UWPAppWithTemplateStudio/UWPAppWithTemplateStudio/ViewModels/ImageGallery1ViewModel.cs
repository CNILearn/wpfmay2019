using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Prism.Commands;
using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

using UWPAppWithTemplateStudio.Core.Models;
using UWPAppWithTemplateStudio.Core.Services;
using UWPAppWithTemplateStudio.Helpers;
using UWPAppWithTemplateStudio.Services;

using Windows.UI.Xaml.Controls;

namespace UWPAppWithTemplateStudio.ViewModels
{
    public class ImageGallery1ViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly ISampleDataService _sampleDataService;
        private readonly IConnectedAnimationService _connectedAnimationService;

        public const string ImageGallery1SelectedIdKey = "ImageGallery1SelectedIdKey";

        private ObservableCollection<SampleImage> _source;
        private ICommand _itemSelectedCommand;

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => SetProperty(ref _source, value);
        }

        public ICommand ItemSelectedCommand => _itemSelectedCommand ?? (_itemSelectedCommand = new DelegateCommand<ItemClickEventArgs>(OnsItemSelected));

        public ImageGallery1ViewModel(INavigationService navigationServiceInstance, ISampleDataService sampleDataServiceInstance, IConnectedAnimationService connectedAnimationService)
        {
            _navigationService = navigationServiceInstance;

            // TODO WTS: Replace this with your actual data
            _sampleDataService = sampleDataServiceInstance;
            _connectedAnimationService = connectedAnimationService;
            Source = _sampleDataService.GetGallerySampleData();
        }

        private void OnsItemSelected(ItemClickEventArgs args)
        {
            var selected = args.ClickedItem as SampleImage;
            ImagesNavigationHelper.AddImageId(ImageGallery1SelectedIdKey, selected.ID);
            _connectedAnimationService.SetListDataItemForNextConnectedAnimation(selected);
            _navigationService.Navigate(PageTokens.ImageGallery1DetailPage, selected.ID);
        }
    }
}
