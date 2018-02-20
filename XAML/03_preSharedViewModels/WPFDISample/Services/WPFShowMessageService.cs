using DISampleViewModels.Services;
using System.Threading.Tasks;
using System.Windows;

namespace WPFDISample.Services
{
    public class WPFShowMessageService : IShowMessageService
    {
        public Task ShowMessageAsync(string message)
        {
            MessageBox.Show(message);
            return Task.CompletedTask;
        }
    }
}
