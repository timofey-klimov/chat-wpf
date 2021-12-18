using Chat.Core.ServicesAbstraction.Providers;
using Chat.Core.ViewModels.Base;
using System;
using System.Windows;

namespace Chat.Core.ViewModels
{
    public class MessageItemViewModel : BaseViewModel
    {
        public string SenderName { get; set; }

        public string Message { get; set; }

        public string Initials { get; set; }

        public string ProfilePictureRGB { get; set; }

        public bool IsSelected { get; set; }

        public bool SentByMe { get; set; }

        public DateTimeOffset MessageReadTime { get; set; }

        public bool MessageRead => MessageReadTime > DateTimeOffset.MinValue;

        public DateTimeOffset MessageSendTime { get; set; }


        public MessageItemViewModel()
        {
        }
    }
}
