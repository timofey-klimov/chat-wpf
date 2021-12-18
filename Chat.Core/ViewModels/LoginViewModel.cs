using Chat.Core.Commands;
using Chat.Core.ServicesAbstraction;
using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Chat.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Properties
        public string Email { get; set; }

        public bool LoginIsRunning { get; set; }

        public bool IsEnabled => !LoginIsRunning;

        #endregion

        #region Commands
        public ICommand LoginCommand { get; }

        public ICommand GoToSinUpCommand { get; }

        #region Services
        public INavigationService NavigationService { get; }
        public IApplicationStateProvider ApplicationStateProvider { get; }

        #endregion

        #endregion

        #region Ctor
        public LoginViewModel(
            INavigationService navigationService,
            IApplicationStateProvider applicationStateProvider)
        {
            NavigationService = navigationService;
            LoginCommand = new DelegateCommand(async (e) => await  Login(e));
            GoToSinUpCommand = new DelegateCommand((e) => GoToSignUp());
            ApplicationStateProvider = applicationStateProvider;
        }

        #endregion

        #region Methods
        private async Task Login(object param)
        {
            await RunCommand(() => LoginIsRunning, async () =>
            {
                await Task.Delay(2000);
                NavigationService.ChangePage(DataModels.ApplicationPage.Chat);
            });
        }

        private void GoToSignUp() 
        {
            NavigationService.ChangePage(DataModels.ApplicationPage.Register);
        }

        #endregion
    }
}
