using Chat.ValueConverters.Base;
using System;
using System.Globalization;
using System.Windows;

namespace Chat.ValueConverters
{
    public class BooleanToHotizontalAlignmnetConveter : BaseValueConverter<BooleanToHotizontalAlignmnetConveter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return HorizontalAlignment.Right;
            else
                return HorizontalAlignment.Left;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
