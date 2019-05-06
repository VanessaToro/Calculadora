using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestCalculator.Utils.DTO
{
    public class ProcesoDto
    {
        public string Digito1 { get; set; }
        public string Digito2 { get; set; }
        public string Digito3 { get; set; }
        public string Operacion { get; set; }
        public string Resultado { get; set; }
        public string Error { get; set; }
    }
}