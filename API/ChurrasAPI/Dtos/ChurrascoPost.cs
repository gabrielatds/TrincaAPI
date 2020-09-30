using System;

namespace ChurrasAPI.Dtos
{
    public class ChurrascoPost
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string ObsAdicional { get; set; }
        public double ValorComBebida { get; set; }
        public double ValorSemBebida { get; set; }
    }
}
