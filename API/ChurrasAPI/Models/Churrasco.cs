using System;
using System.Collections.Generic;

namespace ChurrasAPI.Models
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

        public Churrasco()
        {

        }

        public Churrasco(DateTime data, string descricao, string obsAdicional, double valorComBebida, double valorSemBebida)
        {
            Data = data;
            Descricao = descricao;
            ObsAdicional = obsAdicional;
            ValorComBebida = valorComBebida;
            ValorSemBebida = valorSemBebida;
        }
    }
}
