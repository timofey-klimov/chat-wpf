using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ViewModels.Base;
using System;
using System.Windows;

namespace Chat.Core.ViewModels
{
    public class ChatPageViewModel : BaseViewModel, IDisposable
    {
        public int VerticalPadding { get; set; } = 20;

        private IApplicationStateProvider _stateProvider;

        public ChatPageViewModel(IApplicationStateProvider applicationStateProvider)
        {
            _stateProvider = applicationStateProvider;
            _stateProvider.WindowStateChanged += OnWindowStateChanged;
        }

        private void OnWindowStateChanged(System.Windows.WindowState state)
        {
            if (state == System.Windows.WindowState.Normal)
                VerticalPadding = 20;

            if (state == System.Windows.WindowState.Maximized)
                VerticalPadding = 120;
        }

        public void Dispose()
        {
            _stateProvider.WindowStateChanged -= OnWindowStateChanged;
        }
    }
}
