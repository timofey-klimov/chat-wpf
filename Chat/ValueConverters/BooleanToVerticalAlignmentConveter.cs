using Chat.ValueConverters.Base;
using System;
using System.Globalization;
using System.Windows;

namespace Chat.ValueConverters
{
    public class BooleanToVerticalAlignmentConveter : BaseValueConverter<BooleanToVerticalAlignmentConveter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? VerticalAlignment.Bottom : VerticalAlignment.Center;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
