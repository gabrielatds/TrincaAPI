using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasMVC.Models
{
    public class Participante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Contribuicao { get; set; }
        public bool Pago { get; set; }
        public Churrasco Churrasco { get; set; }
        public int ChurrascoId { get; set; }
    }
}
