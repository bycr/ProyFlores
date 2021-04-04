using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyFlores.Models.ViewModelsBloque
{
    public class ListBloqueViewModel
    {
        public int Idbloque { get; set; }
        public int Numerobloque { get; set; }
        public double Presupuestadoaño { get; set; }
        public double Llevamosaño { get; set; }
        public double Diferenciaaño { get; set; }
        public double Presupuestadomes { get; set; }
        public double Llevamosmes { get; set; }
        public double Diferenciames { get; set; }
        public int Cedula { get; set; }
        public int Idinvernadero { get; set; }
    }
}