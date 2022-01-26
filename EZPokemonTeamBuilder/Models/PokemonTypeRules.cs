using EZPokemonTeamBuilder.Models.Enums;
using System;
using System.Collections.Generic;


namespace EZPokemonTeamBuilder.Models
{
    public class PokemonTypes
    {
        public static readonly List<PokemonType> pokemonTypes = new List<PokemonType>()
        {
            new(TYPES.Normal) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Weak },
                { TYPES.Ghost, DamageMultiplier.Immune },
            }
        },
            new(TYPES.Fighting) {
                TypeMatchups = new() {
                { TYPES.Flying, DamageMultiplier.Weak },
                { TYPES.Rock, DamageMultiplier.Resistant },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Psychic, DamageMultiplier.Weak },
                { TYPES.Dark, DamageMultiplier.Resistant },
                { TYPES.Fairy, DamageMultiplier.Weak }
            }
        },
            new(TYPES.Flying) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Resistant },
                { TYPES.Ground, DamageMultiplier.Immune },
                { TYPES.Rock, DamageMultiplier.Weak },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Grass, DamageMultiplier.Resistant },
                { TYPES.Electric, DamageMultiplier.Weak },
                { TYPES.Ice, DamageMultiplier.Weak },
            }
        },
            new(TYPES.Poison) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Resistant },
                { TYPES.Poison, DamageMultiplier.Resistant },
                { TYPES.Ground, DamageMultiplier.Weak },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Grass, DamageMultiplier.Resistant },
                { TYPES.Psychic, DamageMultiplier.Weak },
                { TYPES.Fairy, DamageMultiplier.Resistant }
            }
        },
            new(TYPES.Ground) {
                TypeMatchups = new() {
                { TYPES.Poison, DamageMultiplier.Resistant },
                { TYPES.Rock, DamageMultiplier.Resistant },
                { TYPES.Water, DamageMultiplier.Weak },
                { TYPES.Grass, DamageMultiplier.Weak },
                { TYPES.Electric, DamageMultiplier.Immune },
                { TYPES.Ice, DamageMultiplier.Weak },
            }
        },
            new(TYPES.Rock) {
                TypeMatchups = new() {
                { TYPES.Normal, DamageMultiplier.Resistant },
                { TYPES.Fighting, DamageMultiplier.Weak },
                { TYPES.Flying, DamageMultiplier.Resistant },
                { TYPES.Poison, DamageMultiplier.Resistant },
                { TYPES.Ground, DamageMultiplier.Weak },
                { TYPES.Steel, DamageMultiplier.Weak },
                { TYPES.Fire, DamageMultiplier.Resistant },
                { TYPES.Water, DamageMultiplier.Weak },
                { TYPES.Grass, DamageMultiplier.Weak },
            }
        },
            new(TYPES.Bug) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Resistant },
                { TYPES.Flying, DamageMultiplier.Weak },
                { TYPES.Ground, DamageMultiplier.Resistant },
                { TYPES.Rock, DamageMultiplier.Weak },
                { TYPES.Fire, DamageMultiplier.Weak },
                { TYPES.Grass, DamageMultiplier.Resistant },
            }
        },
            new(TYPES.Ghost) {
                TypeMatchups = new() {
                { TYPES.Normal, DamageMultiplier.Immune },
                { TYPES.Fighting, DamageMultiplier.Immune },
                { TYPES.Poison, DamageMultiplier.Resistant },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Ghost, DamageMultiplier.Weak },
                { TYPES.Dark, DamageMultiplier.Weak },
            }
        },
            new(TYPES.Steel) {
                TypeMatchups = new() {
                { TYPES.Normal, DamageMultiplier.Resistant },
                { TYPES.Fighting, DamageMultiplier.Weak },
                { TYPES.Flying, DamageMultiplier.Resistant },
                { TYPES.Poison, DamageMultiplier.Immune },
                { TYPES.Ground, DamageMultiplier.Weak },
                { TYPES.Rock, DamageMultiplier.Resistant },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Steel, DamageMultiplier.Resistant },
                { TYPES.Fire, DamageMultiplier.Weak },
                { TYPES.Grass, DamageMultiplier.Resistant },
                { TYPES.Psychic, DamageMultiplier.Resistant },
                { TYPES.Ice, DamageMultiplier.Resistant },
                { TYPES.Dragon, DamageMultiplier.Resistant },
                { TYPES.Fairy, DamageMultiplier.Resistant }
            }
        },
            new(TYPES.Fire) {
                TypeMatchups = new() {
                { TYPES.Ground, DamageMultiplier.Weak },
                { TYPES.Rock, DamageMultiplier.Weak },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Steel, DamageMultiplier.Resistant },
                { TYPES.Fire, DamageMultiplier.Resistant },
                { TYPES.Water, DamageMultiplier.Weak },
                { TYPES.Grass, DamageMultiplier.Resistant },
                { TYPES.Ice, DamageMultiplier.Resistant },
                { TYPES.Fairy, DamageMultiplier.Resistant }
            }
        },
            new(TYPES.Water) {
                TypeMatchups = new() {
                { TYPES.Steel, DamageMultiplier.Resistant },
                { TYPES.Fire, DamageMultiplier.Resistant },
                { TYPES.Water, DamageMultiplier.Resistant },
                { TYPES.Grass, DamageMultiplier.Weak },
                { TYPES.Electric, DamageMultiplier.Weak },
                { TYPES.Ice, DamageMultiplier.Resistant },
            }
        },
            new(TYPES.Grass) {
                TypeMatchups = new() {
                { TYPES.Flying, DamageMultiplier.Weak },
                { TYPES.Poison, DamageMultiplier.Weak },
                { TYPES.Ground, DamageMultiplier.Resistant },
                { TYPES.Bug, DamageMultiplier.Weak },
                { TYPES.Fire, DamageMultiplier.Weak },
                { TYPES.Water, DamageMultiplier.Resistant },
                { TYPES.Grass, DamageMultiplier.Resistant },
                { TYPES.Electric, DamageMultiplier.Resistant },
                { TYPES.Ice, DamageMultiplier.Weak },
            }
        },
            new(TYPES.Electric) {
                TypeMatchups = new() {
                { TYPES.Flying, DamageMultiplier.Resistant },
                { TYPES.Ground, DamageMultiplier.Weak },
                { TYPES.Steel, DamageMultiplier.Resistant },
                { TYPES.Electric, DamageMultiplier.Resistant },
            }
        },
            new(TYPES.Psychic) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Resistant },
                { TYPES.Bug, DamageMultiplier.Weak },
                { TYPES.Ghost, DamageMultiplier.Weak },
                { TYPES.Psychic, DamageMultiplier.Resistant },
                { TYPES.Dark, DamageMultiplier.Weak },
            }
        },
            new(TYPES.Ice) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Weak },
                { TYPES.Rock, DamageMultiplier.Weak },
                { TYPES.Steel, DamageMultiplier.Weak },
                { TYPES.Fire, DamageMultiplier.Weak },
                { TYPES.Ice, DamageMultiplier.Resistant },
            }
        },
            new(TYPES.Dragon) {
                TypeMatchups = new() {
                { TYPES.Fire, DamageMultiplier.Resistant },
                { TYPES.Water, DamageMultiplier.Resistant },
                { TYPES.Grass, DamageMultiplier.Resistant },
                { TYPES.Electric, DamageMultiplier.Resistant },
                { TYPES.Ice, DamageMultiplier.Weak },
                { TYPES.Dragon, DamageMultiplier.Weak },
                { TYPES.Fairy, DamageMultiplier.Weak }
            }
        },
            new(TYPES.Dark) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Weak },
                { TYPES.Bug, DamageMultiplier.Weak },
                { TYPES.Ghost, DamageMultiplier.Resistant },
                { TYPES.Psychic, DamageMultiplier.Immune },
                { TYPES.Dark, DamageMultiplier.Resistant },
                { TYPES.Fairy, DamageMultiplier.Weak }
            }
        },
            new(TYPES.Fairy) {
                TypeMatchups = new() {
                { TYPES.Fighting, DamageMultiplier.Resistant },
                { TYPES.Poison, DamageMultiplier.Weak },
                { TYPES.Bug, DamageMultiplier.Resistant },
                { TYPES.Steel, DamageMultiplier.Weak },
                { TYPES.Dragon, DamageMultiplier.Immune },
                { TYPES.Dark, DamageMultiplier.Resistant },
            }
        },
        };
    }

    public class PokemonType
    {
        private readonly TYPES _value;
        public Dictionary<TYPES, double> TypeMatchups = new();

        public PokemonType() {  }

        public PokemonType(TYPES type)
        {
            _value = type;
        }

        public static implicit operator PokemonType(TYPES value)
        {
            return new PokemonType(value);
        }

        public static implicit operator TYPES(PokemonType value)
        {
            return value._value;
        }
    }

    public struct DamageMultiplier
    {        
        private readonly double _value;

        public static readonly double Normal = 1.0;
        public static readonly double Resistant = 0.5;
        public static readonly double Immune = 0.0;
        public static readonly double Weak = 2.0;

        public DamageMultiplier(DamageMultiplier value)
        {
            if ((double)value != Normal &&
                (double)value != Resistant &&
                (double)value != Immune &&
                (double)value != Weak) { throw new ArgumentException("Invalid value"); }

            _value = (double)value;
        }

        /// <summary>
        /// Multiply 2 values of EFFECTS
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <returns></returns>
        public static DamageMultiplier operator *(DamageMultiplier d1, DamageMultiplier d2)
        {
            return new DamageMultiplier(d1._value * d2._value);
        }

        /// <summary>
        /// Implicit conversion from double to EFFECTS. 
        /// Implicit: No cast operator is required.
        /// </summary>
        public static implicit operator DamageMultiplier(double value)
        {
            if (value != Normal &&
                value != Resistant &&
                value != Immune &&
                value != Weak) { throw new ArgumentException("Invalid value"); }            

            return value;
        }

        /// <summary>
        /// Explicit conversion from EFFECTS to double. 
        /// Explicit: A cast operator is required.
        /// </summary>
        public static explicit operator double(DamageMultiplier value)
        {
            return value._value;
        }
    }
}