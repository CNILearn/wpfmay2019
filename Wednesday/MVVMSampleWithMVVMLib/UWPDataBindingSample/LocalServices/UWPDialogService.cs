using BooksLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace UWPDataBindingSample.LocalServices
{
    public class UWPDialogService : IDialogService
    {
        public async Task ShowMessageAsync(string message, string title)
        {
            var dlg = new MessageDialog(message, title);
            await dlg.ShowAsync();
        }
    }
}
