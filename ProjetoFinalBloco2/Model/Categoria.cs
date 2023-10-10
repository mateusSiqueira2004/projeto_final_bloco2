using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalBloco2.Model
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string? Tipo { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string? DescricaoCategoria { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string? Sigla { get; set; }

        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal Imposto { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string CorBula { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string? Ativa { get; set; }

        [InverseProperty("Categoria")]
        public virtual ICollection<Produto>? Produto { get; set; }
    }
}
