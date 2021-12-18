using Chat.Core.ServicesAbstraction;
using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ServicesImplementation;
using Chat.Core.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Chat.Core.Services.Implementation.IoC
{
    public static class IocContainer
    {
        private static IServiceProvider _provider;

        public static void Init()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<LoginViewModel>();
            serviceCollection.AddTransient<ChatPageViewModel>();
            serviceCollection.AddTransient<RegisterViewModel>();
            serviceCollection.AddSingleton<ApplicationStateViewModel>();
            serviceCollection.AddSingleton<INavigationService, NavigationService>();
            serviceCollection.AddSingleton<IApplicationStateProvider, ApplicationStateProvider>();

            _provider = serviceCollection.BuildServiceProvider(true);
        }

        public static T Get<T>()
        {
            return _provider.GetRequiredService<T>();
        }
    }
}
