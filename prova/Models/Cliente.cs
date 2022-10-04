using System.ComponentModel.DataAnnotations;

namespace prova.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
     
        public DateTime DataNascimento { get; set; }
    }
}
