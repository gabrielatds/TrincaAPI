using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasMVC.Models
{
    public class Churrasco
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string ObsAdicional { get; set; }
        public double ValorComBebida { get; set; }
        public double ValorSemBebida { get; set; }
        public IEnumerable<Participante> Participantes { get; set; }
    }
}
