using Chat.Core.ViewModels;

namespace Chat.Core.ViewModels.Design
{
    public class ChatListItemsDesignModel : ChatListItemViewModel
    {
        public static ChatListItemsDesignModel Instance => new ChatListItemsDesignModel();

        public ChatListItemsDesignModel()
        {
            Initials = "LM";
            Name = "Luke";
            Message = "This chat app is awesome";
            ProfilePictureRGB = "2987BE";
        }
    }
}
