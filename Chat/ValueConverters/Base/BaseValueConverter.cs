using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Chat.ValueConverters.Base
{
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T:BaseValueConverter<T>, new()
    {
        private static T instance;
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);


        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return instance ?? (instance = new T());
        }

    }
}
