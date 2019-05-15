using BooksLibrary.Services;
using DataBindingSample.LocalServices;
using DataBindingSample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DataBindingSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Container = RegisterServices();
        }

        private IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IBooksService, BooksService>();
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<IDialogService, WPFDialogService>();
            return services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
