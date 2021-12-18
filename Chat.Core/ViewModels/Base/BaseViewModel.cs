using Chat.Core.Expressions;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Chat.Core.ViewModels.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected async Task RunCommand(Expression<Func<bool>> updatingFlat, Func<Task> action)
        {
            ///Check if the flag of running is true
            if (updatingFlat.Compile().Invoke())
                return;

            updatingFlat.SetPropertyValue(true);

            try
            {
                await action();
            }
            catch(Exception ex)
            {
            }
            finally
            {
                updatingFlat.SetPropertyValue(false);
            }

        }
    }
}
