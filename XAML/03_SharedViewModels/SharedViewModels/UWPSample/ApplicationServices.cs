using DISampleViewModels.Services;
using DISampleViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using UWPSample.Services;

namespace UWPSample
{
    public class ApplicationServices
    {
        private ApplicationServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<MainViewModel>();
            services.AddSingleton<IShowMessageService, UWPShowMessageService>();
            ServiceProvider = services.BuildServiceProvider();
        }

        private static ApplicationServices _instance;
        private static object _instanceLock = new object();
        private static ApplicationServices GetInstance()
        {
            lock (_instanceLock)
            {
                return _instance ?? (_instance = new ApplicationServices());
            }
        }
        public static ApplicationServices Instance => _instance ?? GetInstance();

        public IServiceProvider ServiceProvider { get; }
    }
}
