using DataBindingSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataBindingSample.ViewModels
{
    public class MainWindowViewModel
    {
        private MainWindowViewModel()
        {
            Initialize();
        }

        private static MainWindowViewModel _instance;

        public static MainWindowViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainWindowViewModel();
                }
                return _instance;
            }
        }

        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

        public ObservableCollection<string> Publishers { get; } = new ObservableCollection<string>();

        private void Initialize()
        {
            var factory = new BookFactory();

            var books = factory.GetBooks();
            foreach (var book in books)
            {
                Books.Add(book);
            }

            var publishers = books.Select(b => b.Publisher).Distinct();

            foreach (var publisher in publishers)
            {
                Publishers.Add(publisher);
            }
            Publishers.Add("*");
        }

        private string _selectedPublisher;

        public string SelectedPublisher
        {
            get => _selectedPublisher;
            set
            {
                _selectedPublisher = value;
                ChangePublisherSelection(_selectedPublisher);
            }
        }

        private void ChangePublisherSelection(string publisher)
        {
            var view = CollectionViewSource.GetDefaultView(Books);
            if (publisher == "*")
            {
                view.Filter = null;
            }
            else
            {
                view.Filter = o =>
                {
                    if (o is Book b)
                    {
                        return b.Publisher == publisher;
                    }
                    return false;
                };
            }
        }

    }
}
