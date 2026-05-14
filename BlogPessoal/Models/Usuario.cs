using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required][StringLength(100)] public string Nome { get; set; } = string.Empty;
        [Required][StringLength(100)][EmailAddress] public string Email { get; set; } = string.Empty;
        [Required][StringLength(255)] public string Senha { get; set; } = string.Empty;

        public ICollection<Postagem>? Postagens { get; set; }

    }
}


