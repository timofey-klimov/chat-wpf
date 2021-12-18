using Chat.Core.DataModels;
using Chat.Pages;
using Chat.ValueConverters.Base;
using System;
using System.Globalization;

namespace Chat.ValueConverters
{
    public class PageConverter : BaseValueConverter<PageConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((ApplicationPage)value) switch
            {
                ApplicationPage.Login => new LoginPage(),
                ApplicationPage.Chat => new ChatPage(),
                ApplicationPage.Register => new RegisterPage(),
                _ => throw new Exception("No such page"),
            };
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
