using Chat.Core.ViewModels;

namespace Chat.Core.Services.Implementation.IoC
{
    public class ServiceLocator
    {
        public static LoginViewModel LoginViewModel => IocContainer.Get<LoginViewModel>();

        public static RegisterViewModel RegisterViewModel => IocContainer.Get<RegisterViewModel>();

        public static ApplicationStateViewModel ApplicationStateViewModel => IocContainer.Get<ApplicationStateViewModel>();

        public static ChatPageViewModel ChatPageViewModel => IocContainer.Get<ChatPageViewModel>();

    }
}
