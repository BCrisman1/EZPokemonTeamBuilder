using System.ComponentModel;

namespace EZPokemonTeamBuilder.Models.CustomEventArgs
{
    public class RichPropertyChangedEventArgs : PropertyChangedEventArgs
    {
        public RichPropertyChangedEventArgs(object oldValue, object newValue, string propertyName) : base(propertyName)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public object OldValue { get; set; }
        public object NewValue { get; set; }
    }
}
