using MusseCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MusseMovil.Services
{
    public class ResenaService : IResenaService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        private const string restUrl = "https://localhost:7078/api/Mapa";

        public List<ResenaDTO> Resenas { get; private set; }

        public ResenaService()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public async Task EnviarComentario(ResenaDTO item)
        {
            Uri uri = new Uri(string.Format(restUrl, string.Empty));

            try
            {
                string json = JsonSerializer.Serialize<ResenaDTO>(item, _serializerOptions);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                response = await _client.PostAsync(uri, content);

                if (response.IsSuccessStatusCode)
                    Debug.WriteLine(@"\tResena successfully saved.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }
        }
        public async Task<List<ResenaDTO>> RefreshDataAsync()
        {
            Resenas = new List<ResenaDTO>();

            Uri uri = new Uri(string.Format(restUrl, string.Empty));
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Resenas = JsonSerializer.Deserialize<List<ResenaDTO>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Resenas;
        }
    }
}
