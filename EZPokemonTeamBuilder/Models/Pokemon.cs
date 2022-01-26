using EZPokemonTeamBuilder.Models.Enums;
using System.Collections.Generic;
using System.Linq;

namespace EZPokemonTeamBuilder.Models
{
    internal class Pokemon
    {
        private string _nationalDex = string.Empty;
        private string _regionalDex = string.Empty;

        public Pokemon()
        {
            Generation = GENERATIONS.Null;
            Species = string.Empty;
            Types = new List<TYPES>();
        }

        public string ImagePath { get; set; }
        public string NationalDex
        {
            get => _nationalDex;
            set
            {
                while (value.Length < 4) { value = value.Insert(0, "0"); }
                if (value.Any(x => !char.IsDigit(x))) { value = "????"; }
                _nationalDex = value;
            }
        }
        public string RegionalDex
        {
            get => _regionalDex;
            set
            {
                while (value.Length < 4) { value = value.Insert(0, "0"); }
                if (value.Any(x => !char.IsDigit(x))) { value = "????"; }
                _regionalDex = value;
            }
        }
        public GENERATIONS Generation { get; set; }
        public string Species { get; set; }
        public List<TYPES> Types { get; set; }
    }
}