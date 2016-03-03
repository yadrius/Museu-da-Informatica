using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Museu_da_Informática.Models
{
    public class Create_Item
    {
        [Required]
        [Display(Name = "Nome do item")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Descrição do Item")]
        public string ProductDescription { get; set; }

        [Required]
        [Display(Name = "Data de fabricação do item")]
        public string ProductDate { get; set; }

        [Required]
        [Display(Name = "Tipo do Item")]
        public string ProductType { get; set; }

    }

    public class Edit_Item
    {
        [Required]
        [Display(Name = "ID do item")]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nome do item")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Descrição do Item")]
        public string ProductDescription { get; set; }

        [Required]
        [Display(Name = "Data de fabricação do item")]
        public string ProductDate { get; set; }

        [Required]
        [Display(Name = "Tipo do Item")]
        public string ProductType { get; set; }

        [Display(Name = "Está excluido")]
        public bool Exclude { get; set; }

    }

    public class Show_Item
    {
        
       
        public  List<Edit_Item> States = new List<Edit_Item>()
    {
        new Edit_Item() {ID = 1, ProductName = "Sniper 01", ProductDescription = "Placa Mãe da Gigabity" , ProductDate = "03/12/1956", ProductType = "Placa Mãe", Exclude = true},
        new Edit_Item() {ID = 2, ProductName = "Gigatron", ProductDescription = "Memoria das Industrias Stark" , ProductDate = "12/01/1961", ProductType = "memória", Exclude = false},
        new Edit_Item() {ID = 3, ProductName = "3755k", ProductDescription = "Processador Intel" , ProductDate = "10/10/2012", ProductType = "Processador" , Exclude = true},
        new Edit_Item() {ID = 4, ProductName = "Optico", ProductDescription = "Mouse das corporações Wayne" , ProductDate = "21/03/1999", ProductType = "Mouse" , Exclude = false},
        };
        
    }
}