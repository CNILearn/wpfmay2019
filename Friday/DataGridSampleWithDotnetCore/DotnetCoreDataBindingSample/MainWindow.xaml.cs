using DataBindingSample.Models;
using DataBindingSample.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBindingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel { get; set; }
        public MainWindow()
        {
           
            InitializeComponent();

     
        }

        private string GetPublisherFromBook(Book book)
        {
            return book.Publisher;
        }


        private void OnShowBook(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(_books.First().Title, _books.First().Publisher);
        }

        private void OnChangeBook(object sender, RoutedEventArgs e)
        {
            // _books.First().Title = "Professional C# 7 and .NET Core 2";
        }

        private void OnAddBook(object sender, RoutedEventArgs e)
        {
            //_books.Add(new Book
            //{
            //    Title = "Professional C# 8 and .NET Core 3",
            //    Publisher = "Wrox Press",
            //    Authors = new[] { "Christian Nagel" }
            //});
        }

        private void SelectedPublisherChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPublisher = e.AddedItems.Cast<string>().FirstOrDefault();

            var view = CollectionViewSource.GetDefaultView(ViewModel.Books);
            if (selectedPublisher == "*")
            {
                view.Filter = null;
            }
            else
            {
                view.Filter = o =>
                {
                    if (o is Book b)
                    {
                        return b.Publisher == selectedPublisher;
                    }
                    return false;
                };
            }
        }

        private void OnInitialized(object sender, EventArgs e)
        {
            ViewModel = new MainWindowViewModel();

            var factory = new BookFactory();

            var books = factory.GetBooks();
            foreach (var book in books)
            {
                ViewModel.Books.Add(book);
            }

            this.DataContext = ViewModel;

            var publishers = books.Select(GetPublisherFromBook).Distinct();

            foreach (var publisher in publishers)
            {
                ViewModel.Publishers.Add(publisher);
            }
            ViewModel.Publishers.Add("*");
        }
    }
}
