using DISampleViewModels.Services;
using GenericViewModels.Core;

namespace DISampleViewModels.ViewModels
{
    public class MainViewModel
    {
        private readonly IShowMessageService _showMessageService;
        public MainViewModel(IShowMessageService showMessageService)
        {
            _showMessageService = showMessageService;

            MessageCommand = new RelayCommand(OnMessage);
        }

        public RelayCommand MessageCommand { get; }

        private async void OnMessage() => await _showMessageService.ShowMessageAsync("Hello from the view-model!");
    }
}
