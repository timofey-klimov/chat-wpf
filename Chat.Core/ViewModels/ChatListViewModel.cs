using Chat.Core.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Chat.Core.ViewModels
{
    public class ChatListViewModel : BaseViewModel
    {
        public ObservableCollection<ChatListItemViewModel> Items { get; set; }

        public ChatListViewModel()
        {
            Items = new();
        }
    }
}
