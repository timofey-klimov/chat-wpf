using System;
using System.Windows;

namespace Chat.Core.ServicesAbstraction.Providers
{
    public interface IApplicationStateProvider
    {
        bool SideMenuVisible { get; set; }

        event Action<System.Windows.WindowState> WindowStateChanged;

        event Action<Size> WindowSizeChanged;

        void StateChanged(WindowState state);

        void ChangeWindowSize(Size size);
    }
}
