using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.ViewModels.Design.Messages
{
    public class MessageItemDesignModel : MessageItemViewModel
    {
        public static MessageItemDesignModel Instance => new MessageItemDesignModel();

        public MessageItemDesignModel()
            :base()
        {
            Message = "Hello, its first message";
        }
    }
}
