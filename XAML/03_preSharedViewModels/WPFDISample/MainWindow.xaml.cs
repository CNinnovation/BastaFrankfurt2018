using DISampleViewModels.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace WPFDISample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public MainViewModel ViewModel => AppServices.Instance.ServiceProvider.GetService<MainViewModel>();
    }
}
