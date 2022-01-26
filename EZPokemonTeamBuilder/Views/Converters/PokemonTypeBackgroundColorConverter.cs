using EZPokemonTeamBuilder.Models.Enums;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;


namespace EZPokemonTeamBuilder.Views.Converters
{
    internal class PokemonTypeBackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not TYPES) {  return null; }

            var type = (TYPES)value;
            Color color = type switch
            {
                TYPES.Normal => (Color)ColorConverter.ConvertFromString("#A8A878"),
                TYPES.Fighting => (Color)ColorConverter.ConvertFromString("#C03028"),
                TYPES.Flying => (Color)ColorConverter.ConvertFromString("#A890F0"),
                TYPES.Poison => (Color)ColorConverter.ConvertFromString("#A040A0"),
                TYPES.Ground => (Color)ColorConverter.ConvertFromString("#E0C068"),
                TYPES.Rock => (Color)ColorConverter.ConvertFromString("#B8A038"),
                TYPES.Bug => (Color)ColorConverter.ConvertFromString("#A8B820"),
                TYPES.Ghost => (Color)ColorConverter.ConvertFromString("#705898"),
                TYPES.Steel => (Color)ColorConverter.ConvertFromString("#B8B8D0"),
                TYPES.Fire => (Color)ColorConverter.ConvertFromString("#F08030"),
                TYPES.Water => (Color)ColorConverter.ConvertFromString("#6890F0"),
                TYPES.Electric => (Color)ColorConverter.ConvertFromString("#F8D030"),
                TYPES.Grass => (Color)ColorConverter.ConvertFromString("#78C850"),
                TYPES.Psychic => (Color)ColorConverter.ConvertFromString("#F85888"),
                TYPES.Ice => (Color)ColorConverter.ConvertFromString("#98D8D8"),
                TYPES.Dragon => (Color)ColorConverter.ConvertFromString("#7038F8"),
                TYPES.Dark => (Color)ColorConverter.ConvertFromString("#705848"),
                TYPES.Fairy => (Color)ColorConverter.ConvertFromString("#EE99AC"),
                _ => Colors.Transparent
            };

            return new SolidColorBrush(color);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
