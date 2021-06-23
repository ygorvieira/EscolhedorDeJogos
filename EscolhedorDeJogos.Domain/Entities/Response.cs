using System.Collections.Generic;

namespace EscolhedorDeJogos.Domain.Entities
{
    public class Response
    {
        public int game_count { get; set; }
        public List<Game> games { get; set; }
    }
}
