using System;
using System.Windows.Input;

namespace Chat.Core.Commands
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _act;
        private readonly Func<object, bool> _canExecute;
        public DelegateCommand(
            Action<object> action,
            Func<object, bool> canExecute = null)
        {
            _act = action;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
       
      

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _act?.Invoke(parameter);
        }
    }
}
