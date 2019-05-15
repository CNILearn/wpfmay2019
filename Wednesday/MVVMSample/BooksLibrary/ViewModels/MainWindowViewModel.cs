using BooksLibrary.Services;
using DataBindingSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestMVVMLibraryInTown;

namespace DataBindingSample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IBooksService _booksService;
        private readonly IDialogService _dialogService;
        public MainWindowViewModel(IBooksService booksService,
            IDialogService dialogService)
        {
            _booksService = booksService;
            _dialogService = dialogService;

            _books = new ObservableCollection<Book>(_booksService.GetBooks());

            ShowBookCommand = new DelegateCommand(ShowBook);
        }

        public DelegateCommand ShowBookCommand { get; }

        private async void ShowBook()
        {
            await _dialogService.ShowMessageAsync(SelectedBook.Title, SelectedBook.Publisher);
        }

        private IList<Book> _books;
        public IList<Book> Books => _books;

        private Book _selectedBook;

        public Book SelectedBook
        {
            get => _selectedBook;
            set => SetProperty(ref _selectedBook, value);
        }
    }
}
