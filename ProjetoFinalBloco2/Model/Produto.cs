using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ProjetoFinalBloco2.Util;

namespace ProjetoFinalBloco2.Model
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string? Nome { get; set; } = string.Empty;

        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string? Decricao { get; set; } = string.Empty;

        [Column(TypeName = "DATE")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateTime DataRecebimento { get; set; }

        [Column(TypeName = "DATE")]
        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public DateTime DataValidade { get; set; }

        [Column(TypeName = "DECIMAL(6,2)")]
        public decimal Preco { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string? Foto { get; set; } = string.Empty;

    }
}
