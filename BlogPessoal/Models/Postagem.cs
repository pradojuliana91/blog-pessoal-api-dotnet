using BlogPessoal.Models;
using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Models
{
    public class Postagem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Conteudo { get; set; } = string.Empty;
        public DateTime DataPublicacao { get; set; } = DateTime.Now;

        public int TemaId { get; set; }
        public Tema? Tema { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }
    }
}


