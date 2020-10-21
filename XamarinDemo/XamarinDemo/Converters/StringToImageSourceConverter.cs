using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace XamarinDemo.Converters
{
    class StringToImageSourceConverter : IValueConverter
    {
        public static StringToImageSourceConverter Instance { get; } = new StringToImageSourceConverter();

        private StringToImageSourceConverter() { } 

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return ImageSource.FromResource((string) value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
