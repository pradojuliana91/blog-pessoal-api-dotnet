using System.ComponentModel.DataAnnotations;

namespace BlogPessoal.Models
{
    public class Tema
    {
        public int Id { get; set; }
        [Required] [StringLength(100)] public string Descricao { get; set; } = string.Empty;

        public ICollection<Postagem>? Postagens { get; set; }
    }
}

