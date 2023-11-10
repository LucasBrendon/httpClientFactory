using HttpClientFactoryDemo.Models;
using HttpClientFactoryDemo.Services.Interfaces;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace HttpClientFactoryDemo.Services
{
    public class ViaCepHttpService : IViaCepHttpService
    {
        private readonly HttpClient _httpClient;

        public ViaCepHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Endereco> ConsultarEndereco(int cep)
        {
            var url = $"https://viacep.com.br/ws/{cep}/json/";

            var response =  await _httpClient.GetAsync(url);

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };

            var endereco = JsonSerializer.Deserialize<Endereco>(await response.Content.ReadAsStringAsync(), options);

            return endereco;
        }
    }
}
