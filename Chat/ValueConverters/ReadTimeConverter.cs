using Chat.ValueConverters.Base;
using System;
using System.Globalization;

namespace Chat.ValueConverters
{
    public class ReadTimeConverter : BaseValueConverter<ReadTimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (DateTimeOffset)value;

            if (time == default)
                return string.Empty;

            if (time.LocalDateTime.Date == DateTime.Now.Date)
                return $"Прочитано {time.LocalDateTime.Date.ToShortTimeString()}";
            else
                return $"Прочитано {time.LocalDateTime:MMMM yyyy}";
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
