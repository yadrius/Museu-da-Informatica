namespace Museu_da_Informática.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cadastro_Pecas
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Tipo")]
        public string tipo { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Marca")]
        public string marca { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Modelo")]
        public string modelo { get; set; }
        [Display(Name = "Peso")]
        
        public double peso { get; set; }
        [Display(Name = "Largura")]
        public double dimensao_largura { get; set; }
        [Display(Name = "Altura")]
        public double dimensao_altura { get; set; }
        [Display(Name = "Profundidade")]
        public double dimensao_profundidade { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Memoria")]
        public string memoria { get; set; }
        [Range(1950, 2015)]       
        [Display(Name = "Ano de fabricação")]
        public int ano_fabricacao { get; set; }
        [Display(Name = "Disponivel a venda")]
        public bool diponibilidade_venda { get; set; }
        [Display(Name = "Existe fisicamente")]
        public bool diponibilidade_visual { get; set; }
    }
}
