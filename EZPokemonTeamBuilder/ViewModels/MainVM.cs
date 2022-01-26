using EZPokemonTeamBuilder.Models;
using EZPokemonTeamBuilder.Models.Utilities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;


namespace EZPokemonTeamBuilder.ViewModels
{
    internal class MainVM : Bindable
    {
        #region PROPERTIES: TeamMemberVM Instances
        public TeamMemberVM TeamMember00 { get => _teamMemberVM_00; set => SetProperty(ref _teamMemberVM_00, value); }
        private TeamMemberVM _teamMemberVM_00;

        public TeamMemberVM TeamMember01 { get => _teamMemberVM_01; set => SetProperty(ref _teamMemberVM_01, value); }
        private TeamMemberVM _teamMemberVM_01;

        public TeamMemberVM TeamMember02 { get => _teamMemberVM_02; set => SetProperty(ref _teamMemberVM_02, value); }
        private TeamMemberVM _teamMemberVM_02;

        public TeamMemberVM TeamMember03 { get => _teamMemberVM_03; set => SetProperty(ref _teamMemberVM_03, value); }
        private TeamMemberVM _teamMemberVM_03;

        public TeamMemberVM TeamMember04 { get => _teamMemberVM_04; set => SetProperty(ref _teamMemberVM_04, value); }
        private TeamMemberVM _teamMemberVM_04;

        public TeamMemberVM TeamMember05 { get => _teamMemberVM_05; set => SetProperty(ref _teamMemberVM_05, value); }
        private TeamMemberVM _teamMemberVM_05;
        #endregion

        public ObservableCollection<Pokemon>? PokemonTeam { get => _pokemonTeam; set => SetProperty(ref _pokemonTeam, value); }
        private static ObservableCollection<Pokemon>? _pokemonTeam;        

        public MainVM()
        {
            InitTeamMemberVMs();
            InitEventHandlers();
        }

        private void TeamMemberVM_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            Debug.WriteLine("A property's value has changed...");
            if (e.PropertyName == nameof(Pokemon))
            {
                Debug.WriteLine("It looks like it was a Pokemon...");
                var pokemonTeam = new ObservableCollection<Pokemon>();
                if (TeamMember00.Pokemon is not null) { pokemonTeam.Add(TeamMember00.Pokemon); }
                if (TeamMember01.Pokemon is not null) { pokemonTeam.Add(TeamMember01.Pokemon); }
                if (TeamMember02.Pokemon is not null) { pokemonTeam.Add(TeamMember02.Pokemon); }
                if (TeamMember03.Pokemon is not null) { pokemonTeam.Add(TeamMember03.Pokemon); }
                if (TeamMember04.Pokemon is not null) { pokemonTeam.Add(TeamMember04.Pokemon); }
                if (TeamMember05.Pokemon is not null) { pokemonTeam.Add(TeamMember05.Pokemon); }
                PokemonTeam = pokemonTeam;
            }
        }

        private void InitTeamMemberVMs()
        {
            PokemonTeam = new ObservableCollection<Pokemon>();
            TeamMember00 = new TeamMemberVM();
            TeamMember01 = new TeamMemberVM();
            TeamMember02 = new TeamMemberVM();
            TeamMember03 = new TeamMemberVM();
            TeamMember04 = new TeamMemberVM();
            TeamMember05 = new TeamMemberVM();
        }

        private void InitEventHandlers()
        {
            TeamMember00.PropertyChanged += TeamMemberVM_PropertyChanged;
            TeamMember01.PropertyChanged += TeamMemberVM_PropertyChanged;
            TeamMember02.PropertyChanged += TeamMemberVM_PropertyChanged;
            TeamMember03.PropertyChanged += TeamMemberVM_PropertyChanged;
            TeamMember04.PropertyChanged += TeamMemberVM_PropertyChanged;
            TeamMember05.PropertyChanged += TeamMemberVM_PropertyChanged;
        }
    }
}