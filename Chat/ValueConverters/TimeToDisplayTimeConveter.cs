using Chat.ValueConverters.Base;
using System;
using System.Globalization;

namespace Chat.ValueConverters
{
    public class TimeToDisplayTimeConveter : BaseValueConverter<TimeToDisplayTimeConveter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (time.LocalDateTime.Date == DateTime.Now.Date)
                return $"{time.LocalDateTime:HH:mm}";
            else
                return time.LocalDateTime.Date.ToShortDateString();
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
