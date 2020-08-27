using EscolhedorDeJogos.Domain.Entities;
using EscolhedorDeJogos.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
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

        public Jogo GetJogos()
        {
            var jogo = new Jogo();
            var usuarioID = "";
            var apiKey = "";

            var path = string.Format(@"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={0}&steamid={1}&format=json", apiKey, usuarioID);

            var request = client.GetAsync(path);

            var response = request.Result.Content.ReadAsAsync<ListaJogosViewModel>();


            return jogo;
        }
    }
}
