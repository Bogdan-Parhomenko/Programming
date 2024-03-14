using System;
using System.Globalization;
using System.Windows;
using System.IO;
using System.Windows.Data;

namespace View.Model.Services
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not bool)
            {
                return null;
            }
            return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, Visibility.Visible))
            {
                return true;
            }
            else if (Equals(value, Visibility.Hidden))
            {
                return false;
            }
            return null;
        }
    }
}
