using DataBindingSample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSample.ViewModels
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

        public ObservableCollection<string> Publishers { get; } = new ObservableCollection<string>();
    }
}
