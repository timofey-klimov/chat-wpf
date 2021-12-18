using Chat.Core.Services.Implementation.IoC;
using System.Windows;

namespace Chat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IocContainer.Init();
            base.OnStartup(e);
        }
    }
}
