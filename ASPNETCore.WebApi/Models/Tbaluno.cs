using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore.WebApi.Models
{
    [Table("TBALUNO", Schema = "FICAI")]
    public partial class Tbaluno
    {
        [Key]
        public int AluId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string AluNom { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AluNomSoc { get; set; }
        [Column(TypeName = "date")]
        public DateTime AluDtaNasc { get; set; }
        [Column("AluCPF")]
        [StringLength(11)]
        [Unicode(false)]
        public string AluCpf { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string AluSexo { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AluFiliacao1 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AluFiliacao2 { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string AluFiliacao3 { get; set; }
        [Column("AluIDINEP")]
        public long? AluIdinep { get; set; }
        public int AluRaca { get; set; }
        public int? AluEndEstId { get; set; }
        [Required]
        [StringLength(80)]
        [Unicode(false)]
        public string AluEndLog { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string AluEndNmrLog { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AluEndCmpLog { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AluEndBairro { get; set; }
        [Column("AluEndCEP")]
        [StringLength(8)]
        [Unicode(false)]
        public string AluEndCep { get; set; }
        [Column("AluEndCidID")]
        public int AluEndCidId { get; set; }
        [Column("AluTelResDDD")]
        [StringLength(3)]
        [Unicode(false)]
        public string AluTelResDdd { get; set; }
        [StringLength(9)]
        [Unicode(false)]
        public string AluTelRes { get; set; }
        [Column("AluTelCelDDD")]
        [StringLength(3)]
        [Unicode(false)]
        public string AluTelCelDdd { get; set; }
        [StringLength(9)]
        [Unicode(false)]
        public string AluTelCel { get; set; }
        [Column("AluTelConDDD")]
        [StringLength(3)]
        [Unicode(false)]
        public string AluTelConDdd { get; set; }
        [StringLength(9)]
        [Unicode(false)]
        public string AluTelCon { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string AluObs { get; set; }
        [Required]
        [StringLength(1)]
        [Unicode(false)]
        public string AluImportado { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string AluStatus { get; set; }
        public int AluIncPor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AluIncEm { get; set; }
        public int? AluAltPor { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AluAltEm { get; set; }
        public int? AluEndBairroId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public int GedAluCodigo { get; set; }
    }
}