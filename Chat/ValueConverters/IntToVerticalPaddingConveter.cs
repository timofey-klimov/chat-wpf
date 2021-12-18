using Chat.ValueConverters.Base;
using System;
using System.Globalization;
using System.Windows;

namespace Chat.ValueConverters
{
    public class IntToVerticalPaddingConveter : BaseValueConverter<IntToVerticalPaddingConveter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var padding = (int)value;
            return new Thickness(0, padding / 2, 0, padding / 2);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
