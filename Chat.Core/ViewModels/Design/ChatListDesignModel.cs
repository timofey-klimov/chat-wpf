using Chat.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Core.ViewModels.Design
{
    public class ChatListDesignModel : ChatListViewModel
    {
        public static ChatListDesignModel Instance => new();

        public ChatListDesignModel()
        {
            Items = new()
            {
                new() 
                { 
                    Message = "Hello, this is my first chat! Is so beaurifull", 
                    Name = "Timofey", 
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22",
                    IsContentAvailable = true
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22",
                    IsSelected = true
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat!",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                },
                new()
                {
                    Message = "Hello, this is my first chat! Is so beaurifull",
                    Name = "Timofey",
                    Initials = "TK",
                    ProfilePictureRGB = "f2aa22"
                }
            };
        }
    }
}
