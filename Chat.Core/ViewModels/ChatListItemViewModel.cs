using Chat.Core.ViewModels.Base;

namespace Chat.Core.ViewModels
{
    public class ChatListItemViewModel : BaseViewModel
    {
        public string Name { get; set; }

        public string Message { get; set; }

        public string Initials { get; set; }

        public string ProfilePictureRGB { get; set; }

        public bool IsContentAvailable { get; set; }

        public bool IsSelected { get; set; }
    }
}
