using EZPokemonTeamBuilder.Models;
using EZPokemonTeamBuilder.Models.Enums;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Data;


namespace EZPokemonTeamBuilder.Views.Converters
{
    internal class ResistanceCountConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {            
            if (!values.Any() || values.Length < 2) { return string.Empty; }

            if (values[0] is not TYPES) { return string.Empty; }
            if (values[1] is not ObservableCollection<Pokemon>) { return string.Empty; }

            if (!((ObservableCollection<Pokemon>)values[1]).Any()) { return string.Empty; }

            var enemyType = (TYPES)values[0];
            var pokemonTeam = values[1] as ObservableCollection<Pokemon>;

            int resistantTypes = 0;
            double modifier = 0.0;

            foreach (var pokemon in pokemonTeam)
            {
                modifier = 1.0;

                foreach (var type in pokemon.Types)
                {
                    if (!PokemonTypes.pokemonTypes.Any(i => i == type)) { continue; }
                    var typeRules = PokemonTypes.pokemonTypes.Where(i => i == type).ToList();

                    if (!typeRules.Any(i => i.TypeMatchups.ContainsKey(enemyType))) { continue; }
                    var matchup = typeRules.Where(i => i.TypeMatchups.ContainsKey(enemyType)).First().TypeMatchups;

                    if (!matchup.TryGetValue(enemyType, out double multiplier)) { continue; }
                    modifier *= (double)multiplier;
                }

                if (modifier > 0.0 && modifier < 1.0) { resistantTypes++; }
            }

            return resistantTypes.ToString();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
