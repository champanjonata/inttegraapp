namespace inttegraapp.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }

        public DateTime DataEmprestimo { get; set; }

        public Contato ContatoId { get; set; } = new Contato();

        public Emprestimo()
        {

        }

        public Emprestimo(int id, DateTime dataEmprestimo, Contato contatoId)
        {
            Id = id;
            DataEmprestimo = dataEmprestimo;
            ContatoId = contatoId;
        }
    }
}
