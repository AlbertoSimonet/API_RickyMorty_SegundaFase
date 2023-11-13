using Newtonsoft.Json;
using API_RickyMorty.Model;



namespace API_RickyMorty.Service
{
    internal class CharacterApiService : ICharacterApiService
    {
        public List<Character> characters = new List<Character>();

        public async Task<List<Character>> GetCharactersAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var urlApi = "https://rickandmortyapi.com/api/character";
                    var respuesta = await httpClient.GetStringAsync(urlApi);
                    var respuestaApi = JsonConvert.DeserializeObject<RespuestaApi>(respuesta);
                    characters = respuestaApi.Results;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Error en el link de la API: " + ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error diferente" + ex);
            }

            return characters;
        }

        public class RespuestaApi
        {
            public List<Character> Results { get; set; }
        }
    }
}

