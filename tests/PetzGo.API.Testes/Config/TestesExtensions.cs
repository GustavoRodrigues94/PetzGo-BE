using System.Net.Http;
using System.Net.Http.Headers;

namespace PetzGo.API.Testes.Config
{
    public static class TestesExtensions
    {
        public static void AtribuirToken(this HttpClient httpClient, string token)
        {
            httpClient.AtribuirJsonMediaType();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        private static void AtribuirJsonMediaType(this HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
