using MusseCore;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MusseMovil.Services
{
    public class MapaService : IMapaService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        private const string restUrl = "https://localhost:7078/api/Mapa";

        public MapaDTO Mapa { get; private set; }

        public MapaService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<MapaDTO> RefreshDataAsync()
        {
            Mapa = new MapaDTO();

            Uri uri = new Uri(string.Format(restUrl, string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Mapa = JsonSerializer.Deserialize<MapaDTO>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Mapa;
        }
    }
}
