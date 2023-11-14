using System.Collections.ObjectModel;
using API_RickyMorty.Model;
using API_RickyMorty.Service;

namespace API_RickyMorty.ViewModel
{
    public class CharactersViewModel
    {
        private readonly ICharacterApiService _characterApiService;
        public ObservableCollection<Character> Characters { get; } = new ObservableCollection<Character>();

        public CharactersViewModel(ICharacterApiService characterApiService)
        {
            _characterApiService = characterApiService;
        }

        public async Task LoadCharactersAsync()
        {
            var characters = await _characterApiService.GetCharactersAsync();
            Characters.Clear();
            foreach (var character in characters)
            {
                Characters.Add(character);
            }
        }
    }


    public class OriginViewModel
    {

        private readonly ICharacterApiService _originApiService;
        public ObservableCollection<Character> Characters { get; } = new ObservableCollection<Character>();

        public OriginViewModel(ICharacterApiService characterApiService)
        {
            _originApiService = characterApiService;
        }


        public async Task LoadCharactersAsync(String condicionOrigin)
        {
            var characters = await _originApiService.GetCharactersAsync();
            Characters.Clear();

            var personajesOrigenEarthRD = characters.Where(character => character.Origin.name == condicionOrigin).ToList();
            foreach (var character in personajesOrigenEarthRD)
            {
                Characters.Add(character);
            }
        }
    }
}
