using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("pessoas")]
    public class Pessoa
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("email")]
        public string Email { get; set; }

    }
}
