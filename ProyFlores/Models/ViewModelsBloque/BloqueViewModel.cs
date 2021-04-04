using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyFlores.Models.ViewModelsBloque
{
    public class BloqueViewModel
    {
        public int Idbloque { get; set; }
        [Required]
        [Display(Name ="Numero de bloque")]
        public int Numerobloque { get; set; }
        [Required]
        public double Presupuestadoaño { get; set; }
        [Required]
        public double Llevamosaño { get; set; }
        [Required]
        public double Diferenciaaño { get; set; }
        [Required]
        public double Presupuestadomes { get; set; }
        [Required]
        public double Llevamosmes { get; set; }
        [Required]
        public double Diferenciames { get; set; }
        [Required]
        public int Cedula { get; set; }
        [Required]
        public int Idinvernadero { get; set; }
    }
}