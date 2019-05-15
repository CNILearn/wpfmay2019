using BooksLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingSample.LocalServices
{
    class WPFDialogService : IDialogService
    {
        public Task ShowMessageAsync(string message, string title)
        {
            MessageBox.Show(message, title);
            return Task.CompletedTask;
        }
    }
}
