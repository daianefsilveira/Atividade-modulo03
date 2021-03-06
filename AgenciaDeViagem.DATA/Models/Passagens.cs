// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AgenciaDeViagem.DATA.Models
{
    [Table("PASSAGENS")]
    public partial class Passagens
    {
        public Passagens()
        {
            Compra = new HashSet<Compra>();
        }

        [Key]
        public int CódPassagem { get; set; }
        [Required]
        [StringLength(50)]
        public string Destino { get; set; }
        [Required]
        [StringLength(50)]
        public string Trecho { get; set; }

        [DisplayName("Quantidade de Passagens")]
        public int QtdPassagem { get; set; }
        [Column(TypeName = "decimal(5, 5)")]
        public decimal ValorPassagem { get; set; }

        [InverseProperty("CódPassagemNavigation")]
        public virtual ICollection<Compra> Compra { get; set; }
    }
}