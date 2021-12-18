using Chat.Core.Services.Implementation.IoC;
using Chat.Core.ServicesAbstraction.Providers;
using System;

namespace Chat.Core.ViewModels.Design.Messages
{
    public class MessageItemsDesignModel : MessageListViewModel
    {
        public static MessageItemsDesignModel Instance => new MessageItemsDesignModel();

        public MessageItemsDesignModel()
            :base(IocContainer.Get<IApplicationStateProvider>())
        {
            Items = new()
            {
                new MessageItemViewModel()
                {
                    SenderName = "Me",
                    Initials = "PL",
                    Message = "Существуют две основные трактовки понятия «текст»: имманентная (расширенная, философски нагруженная) и репрезентативная (более частная). Имманентный подход подразумевает отношение к тексту как к автономной реальности, нацеленность на выявление его внутренней структуры. Репрезентативный — рассмотрение текста как особой формы представления информации о внешней тексту действительности.",
                    ProfilePictureRGB = "3099c5",
                    MessageSendTime = System.DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new MessageItemViewModel()
                {
                    SenderName = "Me",
                    Initials = "PL",
                    Message = "New message available",
                    ProfilePictureRGB = "3099c5",
                    MessageSendTime = System.DateTimeOffset.UtcNow,
                    SentByMe = true,
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract (TimeSpan.FromDays(10))
                },
                new MessageItemViewModel()
                {
                    SenderName = "Me",
                    Initials = "PL",
                    Message = "New message available",
                    ProfilePictureRGB = "3099c5",
                    MessageSendTime = System.DateTimeOffset.UtcNow,
                    SentByMe = false
                }
            };
        }
    }
}
