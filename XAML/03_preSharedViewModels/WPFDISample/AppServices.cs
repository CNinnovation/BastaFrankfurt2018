using DISampleViewModels.Services;
using DISampleViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using WPFDISample.Services;

namespace WPFDISample
{
    public class AppServices
    {
        private AppServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainViewModel>();
            services.AddSingleton<IShowMessageService, WPFShowMessageService>();
            ServiceProvider = services.BuildServiceProvider();
        }

        private static AppServices _instance;
        private static object _instanceLock = new object();
        private static AppServices GetInstance()
        {
            lock (_instanceLock)
            {
                return _instance ?? (_instance = new AppServices());
            }
        }
        public static AppServices Instance => _instance ?? GetInstance();

        public IServiceProvider ServiceProvider { get; }
    }
}
