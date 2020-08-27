using System.Runtime.Serialization;

namespace EscolhedorDeJogos.Domain.Entities
{
    [DataContract(Name = "game")]
    public class Jogo
    {
        [DataMember(Name = "appid")]
        public int ID { get; set; }

        [DataMember(Name = "playtime_forever")]
        public int TempoTotal { get; set; }

        [DataMember(Name = "playtime_windows_forever")]
        public int TempoWindows { get; set; }

        [DataMember(Name = "playtime_mac_forever")]
        public int TempoMac { get; set; }

        [DataMember(Name = "playtime_linux_forever")]
        public int TempoLinux { get; set; }        
    }
}
