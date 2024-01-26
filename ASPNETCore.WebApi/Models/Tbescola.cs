using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore.WebApi.Models
{
    [Table("TBESCOLA", Schema = "FICAI")]
    public partial class Tbescola
    {
        [Key]
        public int EscId { get; set; }
        public int? EscCod { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string EscNom { get; set; }
        [Required]
        [StringLength(80)]
        [Unicode(false)]
        public string EscEndLog { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string EscEndNmrLog { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EscEndCmpLog { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EscEndBairro { get; set; }
        [Column("EscEndCEP")]
        [StringLength(8)]
        [Unicode(false)]
        public string EscEndCep { get; set; }
        public int? EscEstId { get; set; }
        [Column("EscEndCidID")]
        public int EscEndCidId { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string EscEndCidNom { get; set; }
        [Column("EscTelDDD")]
        [StringLength(3)]
        [Unicode(false)]
        public string EscTelDdd { get; set; }
        [StringLength(9)]
        [Unicode(false)]
        public string EscTel { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string EscEmail { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string EscTipo { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string EscStatus { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string EscImportada { get; set; }
        public int EscIncPor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EscIncEm { get; set; }
        public int? EscAltPor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EscAltEm { get; set; }
        public int? EscEndBairroId { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string EscCategoria { get; set; }
    }
}