using Chat.Core.DataModels;
using System;

namespace Chat.Core.ServicesAbstraction
{
    public interface INavigationService
    {
        event Action<ApplicationPage> PageChanged;

        void ChangePage(ApplicationPage page);
    }
}
