using EZPokemonTeamBuilder.Models;
using EZPokemonTeamBuilder.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace EZPokemonTeamBuilder.Views.Converters
{
    internal class PokemonTypeMatchupMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {            
            Style labelStyle = new Style();
            if (!values.Any() || values.Length < 3) { return labelStyle; }
            
            if (values[0] is not TYPES) { return labelStyle; }
            if (values[1] is not List<TYPES>) { return labelStyle; }
            if (values[2] is not UserControl) { return labelStyle; }

            var enemyType = (TYPES)values[0];
            var pokemonType = (List<TYPES>)values[1];
            var sender = (UserControl)values[2];

            double modifier = 1.0;

            foreach (var type in pokemonType)
            {
                if (!PokemonTypes.pokemonTypes.Any(i => i == type)) { continue; }
                var typeRules = PokemonTypes.pokemonTypes.Where(i => i == type).ToList();
                
                if (!typeRules.Any(i => i.TypeMatchups.ContainsKey(enemyType))) { continue; }
                var matchup = typeRules.Where(i => i.TypeMatchups.ContainsKey(enemyType)).First().TypeMatchups;
                
                if (!matchup.TryGetValue(enemyType, out double multiplier)) { continue; }
                modifier *= (double)multiplier;
            }            

            if (modifier == 1.0) { labelStyle = (Style)sender.FindResource("LabelStyleDamageNormal"); }
            if (modifier == 0.0) { labelStyle = (Style)sender.FindResource("LabelStyleDamageImmunity"); }
            if (modifier == 0.5) { labelStyle = (Style)sender.FindResource("LabelStyleDamageOneHalf"); }
            if (modifier == 0.25) { labelStyle = (Style)sender.FindResource("LabelStyleDamageOneQuarter"); }
            if (modifier == 2.0) { labelStyle = (Style)sender.FindResource("LabelStyleDamageDouble"); }
            if (modifier == 4.0) { labelStyle = (Style)sender.FindResource("LabelStyleDamageQuadruple"); }

            return labelStyle;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
