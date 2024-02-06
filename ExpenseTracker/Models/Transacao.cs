using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Transacao
    {
        [Key]
        public int IdTransacao { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public int Quantidade { get;set; }
        [Column(TypeName = "nvarchar(75)")]
        public string Observacao { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
