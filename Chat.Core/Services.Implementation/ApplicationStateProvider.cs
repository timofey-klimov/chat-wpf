using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ViewModels;
using System;
using System.Windows;

namespace Chat.Core.ServicesImplementation
{
    public class ApplicationStateProvider : IApplicationStateProvider
    {
        private ApplicationStateViewModel _app;

        public event System.Action<WindowState> WindowStateChanged;
        public event Action<Size> WindowSizeChanged;

        public bool SideMenuVisible  
        {
            get => _app.ExpandSideMenu;
            set => _app.ExpandSideMenu = value;
        }

        public ApplicationStateProvider(ApplicationStateViewModel applicationStateView)
        {
            _app = applicationStateView;
        }

        public void StateChanged(WindowState state)
        {
            WindowStateChanged?.Invoke(state);
        }

        public void ChangeWindowSize(Size size)
        {
            WindowSizeChanged?.Invoke(size);
        }
    }
}
