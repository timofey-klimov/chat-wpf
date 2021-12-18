using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Chat.Core.ViewModels
{
    public class MessageListViewModel : BaseViewModel, IDisposable
    {
        public double MaxMessageBlockWidth { get; set; } = 400;

        public ObservableCollection<MessageItemViewModel> Items { get; set; }

        private IApplicationStateProvider _stateProvider;

        public MessageListViewModel(IApplicationStateProvider applicationStateProvider)
        {
            Items = new();
            _stateProvider = applicationStateProvider;
            _stateProvider.WindowSizeChanged += OnWindowSizeChanged;
        }

        private void OnWindowSizeChanged(Size size)
        {
            MaxMessageBlockWidth = size.Width / 2;
        }

        public void Dispose()
        {
            _stateProvider.WindowSizeChanged -= OnWindowSizeChanged;
        }
    }
}
