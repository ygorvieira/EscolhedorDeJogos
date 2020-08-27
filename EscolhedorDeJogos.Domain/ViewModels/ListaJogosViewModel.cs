using EscolhedorDeJogos.Domain.Entities;

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EscolhedorDeJogos.Domain.ViewModels
{
    [DataContract(Name = "response")]
    public class ListaJogosViewModel
    {
        [DataMember(Name = "game_count")]
        public int Total { get; set; }

        [DataMember(Name = "games")]
        public List<Jogo> Jogos { get; set; }
    }
}
