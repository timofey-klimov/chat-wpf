using Chat.Core.DataModels;
using Chat.Core.ServicesAbstraction;
using Chat.Core.ServicesAbstraction.Providers;
using System;

namespace Chat.Core.Services.Implementation
{
    public class NavigationService : INavigationService
    {
        private readonly IApplicationStateProvider _applicationStateProvider;
        public NavigationService(IApplicationStateProvider applicationStateProvider)
        {
            _applicationStateProvider = applicationStateProvider;
        }
        public event Action<ApplicationPage> PageChanged;

        public void ChangePage(ApplicationPage page)
        {
            if (page == ApplicationPage.Chat)
                _applicationStateProvider.SideMenuVisible = true;
            PageChanged?.Invoke(page);
        }
    }
}
