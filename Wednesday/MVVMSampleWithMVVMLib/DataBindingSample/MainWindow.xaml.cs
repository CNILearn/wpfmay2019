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
using Microsoft.Extensions.DependencyInjection;
using BooksLibrary.Services;
using DataBindingSample.LocalServices;

namespace DataBindingSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // ViewModel = (Application.Current as App).Container.GetService<MainWindowViewModel>();
            //var booksService = new BooksService();
            //var dialogService = new WPFDialogService();
            //ViewModel = new MainWindowViewModel(booksService, dialogService);
            ViewModel = AppServices.Instance.Container.GetService<MainWindowViewModel>();
            InitializeComponent();
            this.DataContext = this;
        }

        public MainWindowViewModel ViewModel { get; }

        //private void OnShowBook(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(_books.First().Title, _books.First().Publisher);
        //}

        //private void OnChangeBook(object sender, RoutedEventArgs e)
        //{
        //    _books.First().Title = "Professional C# 7 and .NET Core 2";
        //}

        //private void OnAddBook(object sender, RoutedEventArgs e)
        //{
        //    _books.Add(new Book
        //    {
        //        Title = "Professional C# 8 and .NET Core 3",
        //        Publisher = "Wrox Press",
        //        Authors = new[] { "Christian Nagel" }
        //    });
        //}
    }
}
