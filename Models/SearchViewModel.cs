namespace Museu_da_Informática.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public class SearchViewModel
    {     
            
            [Required]
            public string Query { get; set; }
        
    }
}