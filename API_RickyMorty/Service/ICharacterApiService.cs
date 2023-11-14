using API_RickyMorty.Model;


namespace API_RickyMorty.Service
{
    public interface ICharacterApiService
    {
        public Task<List<Character>> GetCharactersAsync();
    }
}
