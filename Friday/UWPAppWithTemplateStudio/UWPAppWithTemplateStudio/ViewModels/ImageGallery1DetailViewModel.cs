using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Prism.Windows.Mvvm;
using Prism.Windows.Navigation;

using UWPAppWithTemplateStudio.Core.Models;
using UWPAppWithTemplateStudio.Core.Services;
using UWPAppWithTemplateStudio.Helpers;
using UWPAppWithTemplateStudio.Services;

using Windows.System;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace UWPAppWithTemplateStudio.ViewModels
{
    public class ImageGallery1DetailViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly ISampleDataService _sampleDataService;
        private readonly IConnectedAnimationService _connectedAnimationService;
        private object _selectedImage;
        private ObservableCollection<SampleImage> _source;

        public object SelectedImage
        {
            get => _selectedImage;
            set
            {
                SetProperty(ref _selectedImage, value);
                ImagesNavigationHelper.UpdateImageId(ImageGallery1ViewModel.ImageGallery1SelectedIdKey, ((SampleImage)SelectedImage).ID);
            }
        }

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => SetProperty(ref _source, value);
        }

        public ImageGallery1DetailViewModel(INavigationService navigationServiceInstance, ISampleDataService sampleDataServiceInstance, IConnectedAnimationService connectedAnimationService)
        {
            _navigationService = navigationServiceInstance;

            // TODO WTS: Replace this with your actual data
            _sampleDataService = sampleDataServiceInstance;
            _connectedAnimationService = connectedAnimationService;
            Source = _sampleDataService.GetGallerySampleData();
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);
            var selectedImageID = e.Parameter as string;

            if (!string.IsNullOrEmpty(selectedImageID) && e.NavigationMode == NavigationMode.New)
            {
                SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageID);
            }
            else
            {
                selectedImageID = ImagesNavigationHelper.GetImageId(ImageGallery1ViewModel.ImageGallery1SelectedIdKey);
                if (!string.IsNullOrEmpty(selectedImageID))
                {
                    SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageID);
                }
            }
        }

        public void HandleKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Escape && _navigationService.CanGoBack())
            {
                _navigationService.GoBack();
                e.Handled = true;
            }
        }

        public override void OnNavigatingFrom(NavigatingFromEventArgs e, Dictionary<string, object> viewModelState, bool suspending)
        {
            base.OnNavigatingFrom(e, viewModelState, suspending);
            if (e.NavigationMode == NavigationMode.Back)
            {
                _connectedAnimationService.SetListDataItemForNextConnectedAnimation(SelectedImage);
                ImagesNavigationHelper.RemoveImageId(ImageGallery1ViewModel.ImageGallery1SelectedIdKey);
            }
        }
    }
}
