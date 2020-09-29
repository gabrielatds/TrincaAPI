using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI.Models
{
    public class Churrasco
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string ObsAdicional { get; set; }
        public List<Participante> Participantes { get; set; } = new List<Participante>();
    }
}
