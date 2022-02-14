using CsvHelper.Configuration.Attributes;
using LINQtoCSV;
using System.ComponentModel.DataAnnotations;

namespace inttegraapp.Models
{
    public class Contato
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]

        public string Name { get; set; }

        [Display(Name = "E-mail")]

        public string Email { get; set; }

        [Display(Name = "Aniversário")]
        public DateTime Aniversario { get; set; }

        public string Telefone { get; set; }

        public Contato()
        {

        }

        public Contato(int id, string name, string email, DateTime aniversario, string telefone)
        {
            Id = id;
            Name = name;
            Email = email;
            Aniversario = aniversario;
            Telefone = telefone;
        }
    }
}
