using System;
using System.Globalization;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace EZPokemonTeamBuilder.Views.Converters
{
    internal class StringToImageUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not string || string.IsNullOrEmpty(value.ToString()) || !File.Exists(value.ToString()))
            { return null; }
            
            BitmapImage bitmap = new BitmapImage(new Uri(value.ToString(), UriKind.RelativeOrAbsolute));
            ImageBrush image = new ImageBrush();
            image.ImageSource = bitmap;
            return image.ImageSource;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
