using Chat.ValueConverters.Base;
using System;
using System.Globalization;
using System.Windows;

namespace Chat.ValueConverters
{
    public class VisibilityToBooleanConverter : BaseValueConverter<VisibilityToBooleanConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (Visibility)value == Visibility.Visible ? true : false;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
