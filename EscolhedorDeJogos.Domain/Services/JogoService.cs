using EscolhedorDeJogos.Domain.Entities;
using EscolhedorDeJogos.Domain.Utils;

using Newtonsoft.Json;

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EscolhedorDeJogos.Domain.Service
{
    public class JogoService
    {
        private readonly HttpClient client;

        public JogoService()
        {
            client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<BibliotecaGames> GetJogos()
        {
            var jogos = new BibliotecaGames();
            var usuarioID = Constants.usuarioID;
            var apiKey = Constants.apiKey;

            var path = string.Format(@"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={0}&steamid={1}&format=json", apiKey, usuarioID);

            var response = client.GetAsync(path).Result;
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ReasonPhrase);
            }
            if (response.IsSuccessStatusCode)
            {
                jogos = await response.Content.ReadAsAsync<BibliotecaGames>();
            }            

            return jogos;
        }
    }
}
