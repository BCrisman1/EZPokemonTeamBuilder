using EZPokemonTeamBuilder.Models.Utilities;
using EZPokemonTeamBuilder.Views;
using System.Windows.Controls;


namespace EZPokemonTeamBuilder.ViewModels
{
    public class MainWindowVM : Bindable
    {
        private UserControl? _view = null;
        public UserControl? View { get => _view; set => SetProperty(ref _view, value); }

        public MainWindowVM()
        {
            View = new MainView();
        }
    }
}