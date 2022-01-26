using EZPokemonTeamBuilder.Models;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace EZPokemonTeamBuilder.Views.Extensions
{
    public static class ComboBoxExtensions
    {
        public static void MakeComboBoxSearchable(this ComboBox targetComboBox)
        {
            targetComboBox.Loaded += TargetComboBox_Loaded;
        }

        private static void TargetComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var targetComboBox = sender as ComboBox;
            var targetTextBox = targetComboBox?.Template.FindName("PART_EditableTextBox", targetComboBox) as TextBox;

            if (targetTextBox == null) return;

            targetComboBox.Tag = "TextInput";
            targetComboBox.StaysOpenOnEdit = true;
            targetComboBox.IsEditable = true;
            targetComboBox.IsTextSearchEnabled = false;

            targetTextBox.TextChanged += (o, args) =>
            {
                var textBox = (TextBox)o;

                var searchText = textBox.Text;

                if (targetComboBox.Tag.ToString() == "Selection")
                {
                    targetComboBox.Tag = "TextInput";
                    targetComboBox.IsDropDownOpen = true;
                }
                else
                {
                    if (targetComboBox.SelectionBoxItem != null)
                    {
                        targetComboBox.SelectedItem = null;
                        targetTextBox.Text = searchText;
                        textBox.CaretIndex = targetTextBox.Text.Length;
                    }

                    if (string.IsNullOrEmpty(searchText))
                    {
                        targetComboBox.Items.Filter = item => true;
                        targetComboBox.SelectedItem = default(object);
                    }
                    else
                    {                        
                        targetComboBox.Items.Filter = i => ((Pokemon)i).Species.StartsWith(searchText, true, CultureInfo.InvariantCulture);
                    }
                        

                    Keyboard.ClearFocus();
                    Keyboard.Focus(targetTextBox);                    
                    targetTextBox.CaretIndex = targetComboBox.Text.Length;
                    targetComboBox.IsDropDownOpen = true;
                }
            };


            targetComboBox.SelectionChanged += (o, args) =>
            {
                var comboBox = o as ComboBox;
                if (comboBox?.SelectedItem == null) return;
                targetTextBox.CaretIndex = targetComboBox.Text.Length;
                comboBox.Tag = "Selection";
            };
        }
    }
}