using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Carro
    {
        public long Id { get; set; }

        public long Id_Marca { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string Modelo { get; set; }

        [Display(Name ="Year")]
        public int Ano { get; set; }


        public string Cor { get; set; }
    }
}
