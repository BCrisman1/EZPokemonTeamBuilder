using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace EZPokemonTeamBuilder.Views.Converters
{
    internal class IntegerToBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not string) { return null; }
            if (parameter is not string || string.IsNullOrEmpty(parameter.ToString())) { return null; }

            if (!int.TryParse(value.ToString(), out int result)) { return null; }
            string? param = parameter.ToString();

            Color color = (param == "Resistance") ? result switch
            {
                0 => Colors.Transparent,
                1 => (Color)ColorConverter.ConvertFromString("#7F007F00"),
                2 => (Color)ColorConverter.ConvertFromString("#7F00BF00"),
                _ => (Color)ColorConverter.ConvertFromString("#7F00FF00")
            } : result switch
            {
                0 => Colors.Transparent,
                1 => (Color)ColorConverter.ConvertFromString("#FFDF0000"),
                2 => (Color)ColorConverter.ConvertFromString("#FF6D0000"),
                _ => (Color)ColorConverter.ConvertFromString("#FF4B0000")
            };

            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
