using EZPokemonTeamBuilder.Models;
using EZPokemonTeamBuilder.Models.Utilities;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace EZPokemonTeamBuilder.ViewModels
{
    internal class TeamMemberVM : Bindable
    {        
        public ObservableCollection<Pokemon>? Pokedex { get => _pokedex; set => SetProperty(ref _pokedex, value); }
        private static ObservableCollection<Pokemon>? _pokedex = null;

        public Pokemon? Pokemon { get => _pokemon; set => SetProperty(ref _pokemon, value); }
        public Pokemon? _pokemon = null;

        public TeamMemberVM()
        {            
            LoadPokedex();
            //SetImagePaths();
        }

        private void LoadPokedex()
        {
            if (Pokedex is not null) { return; }

            var dexRelPath = @"Resources\pokemon_nationaldex.json";
            if (!File.Exists(dexRelPath)) { return; }

            var pokedexString = File.ReadAllText(dexRelPath);
            if (pokedexString == null) { return; }

            var pokedex = JsonConvert.DeserializeObject<ObservableCollection<Pokemon>>(pokedexString);
            if (pokedex == null) { return; }

            Pokedex = pokedex;

            ValidateImagePaths();
        }

        private void ValidateImagePaths()
        {
            if (Pokedex != null && Pokedex.Any(i => string.IsNullOrEmpty(i.ImagePath)))
            {
                var pokemonMissingImagePaths = Pokedex.Where(i => string.IsNullOrEmpty(i.ImagePath)).ToList();
                pokemonMissingImagePaths.ForEach(i => Debug.WriteLine($"{i.Species} has no image file association."));
            }

            foreach (var pokemon in Pokedex)
            {
                if (pokemon != null && !string.IsNullOrEmpty(pokemon.ImagePath) && File.Exists(pokemon.ImagePath)) { continue; }
                Debug.WriteLine($"Image File ({pokemon.ImagePath}) not found!");
            }

            
        }

        private void SetImagePaths()
        {
            if (Pokedex is null) { return; }
            
            var assets = Directory.GetFiles("Assets").ToList();

            foreach (var pokemon in Pokedex)
            {
                var matchingAssets = assets.Where(i => i.Contains(pokemon.Species)).ToArray();
                if (!matchingAssets.Any()) { continue; }

                var assetPath = matchingAssets.First();
                if (!File.Exists(assetPath)) { continue; }

                var oldAssetPath = assetPath;

                assets.Remove(assetPath);

                int increment = 0;

                while (assetPath.Contains("000")) 
                {
                    increment++;
                    int startIndex = assetPath.IndexOf("000");
                    assetPath = assetPath.Remove(startIndex, 3);
                }

                if (increment > 0)
                {                    
                    var ext = Path.GetExtension(assetPath);
                    var filenameNoExt = Path.GetFileNameWithoutExtension(assetPath);
                    var relativePath = Path.GetDirectoryName(assetPath);
                    string insert = increment.ToString();
                    while (insert.Length < 3) { insert = insert.Insert(0, "0"); }
                    assetPath = Path.Combine(relativePath, $"{filenameNoExt}{insert}{ext}");
                }

                if (oldAssetPath != assetPath)
                {
                    File.Copy(oldAssetPath, assetPath, true);
                    File.Delete(oldAssetPath);
                }                

                pokemon.ImagePath = assetPath;
            }

            if (Pokedex.Any(i => string.IsNullOrEmpty(i.ImagePath)))
            {
                string missingImagePaths = string.Empty;
                Pokedex.Where(i => string.IsNullOrEmpty(i.ImagePath)).Select(i => i.Species).ToList().ForEach(i => missingImagePaths += $"{i}\n");
                System.Diagnostics.Debug.WriteLine($"Failed to set image path: {missingImagePaths}");
            }

            UpdatePokeDex();
        }

        private void UpdatePokeDex()
        {
            if (Pokedex is null || !Pokedex.Any()) { return; }

            var dexRelPath = @"Resources\pokemon_nationaldex.json";
            var jsonOutput = JsonConvert.SerializeObject(Pokedex, Formatting.Indented);
            if (!string.IsNullOrEmpty(jsonOutput)) { File.WriteAllText(dexRelPath, jsonOutput); }
        }
    }
}