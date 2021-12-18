using Chat.ValueConverters.Base;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chat.ValueConverters
{
    public class BackgroundMessageConveter : BaseValueConverter<BackgroundMessageConveter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return Application.Current.FindResource("ForegroundLightBlueBrush");
            else
                return Application.Current.FindResource("BackgroundVeryLightBrush");
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
