using Chat.Core.Commands;
using Chat.Core.ServicesAbstraction;
using Chat.Core.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chat.Core.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand RegisterCommand { get; }

        public ICommand GoToSignInCommand { get; }

        public bool IsRegisterRunning { get; set; }

        public RegisterViewModel(INavigationService navigationService)
        {
            GoToSignInCommand = new DelegateCommand((e) => navigationService.ChangePage(DataModels.ApplicationPage.Login));
            RegisterCommand = new DelegateCommand(async (e) => await Register(e));
        }

        public async Task Register(object p)
        {
            await RunCommand(() => IsRegisterRunning, async () => await Task.Delay(4000));
        }
    }
}
