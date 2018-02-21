using System.Threading.Tasks;

namespace DISampleViewModels.Services
{
    public interface IShowMessageService
    {
        Task ShowMessageAsync(string message);
    }
}
