using DISampleViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using UWPSample;
using Windows.UI.Xaml.Controls;

namespace UWPApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public MainViewModel ViewModel => ApplicationServices.Instance.ServiceProvider.GetService<MainViewModel>();
    }
}
