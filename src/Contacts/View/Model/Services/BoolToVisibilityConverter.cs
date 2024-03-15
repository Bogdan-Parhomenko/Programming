using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Model.Services
{
    /// <summary>
    /// Сервисный класс для конвертации свойства visibility.
    /// </summary>
    public class BoolToVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="value"><inheritdoc/></param>
        /// <param name="targetType"><inheritdoc/></param>
        /// <param name="parameter"><inheritdoc/></param>
        /// <param name="culture"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not bool)
            {
                return null;
            }
            return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="value"><inheritdoc/></param>
        /// <param name="targetType"><inheritdoc/></param>
        /// <param name="parameter"><inheritdoc/></param>
        /// <param name="culture"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
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
