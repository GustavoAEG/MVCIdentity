using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCIdentity.Models
{
    [Table("Contatos")]
    public class Contato
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
    }
}
