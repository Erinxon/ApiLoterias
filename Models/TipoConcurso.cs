using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class TipoConcurso
    {
        public string Nombre { get; set; }
        public string[] Numeros { get; set; }
        public string Fecha { get; set; }
    }
}
