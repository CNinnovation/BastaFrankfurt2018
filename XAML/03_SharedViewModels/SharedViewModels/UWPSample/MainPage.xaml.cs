using DISampleViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Windows.UI.Xaml.Controls;

namespace UWPSample
{
    public sealed partial class MainPage : Page
    {
        public MainPage() => InitializeComponent();

        public MainViewModel ViewModel => ApplicationServices.Instance.ServiceProvider.GetService<MainViewModel>();
    }
}
