using BooksLibrary.Services;
using DataBindingSample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPDataBindingSample.LocalServices;

namespace UWPDataBindingSample
{
    // Singleton pattern
    public class AppServices
    {
        private AppServices()
        {
            Container = RegisterServices();
        }

        private static AppServices _instance;
        public static AppServices Instance
        {
            get => _instance ?? (_instance = new AppServices());
        }

        private IServiceProvider RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IBooksService, BooksService>();
            services.AddTransient<MainWindowViewModel>();
            services.AddTransient<IDialogService, UWPDialogService>();
            return services.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
