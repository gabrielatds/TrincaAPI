namespace ChurrasAPI.Models
{
    public class Participante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Contribuicao { get; set; }
        public bool Pago { get; set; }
        public Churrasco Churrasco { get; set; }
        public int ChurrascoId { get; set; }

        public Participante()
        {

        }

        public Participante(string nome, double contribuicao, bool pago, Churrasco churrasco)
        {
            Nome = nome;
            Contribuicao = contribuicao;
            Pago = pago;
            Churrasco = churrasco;
        }
    }
}
