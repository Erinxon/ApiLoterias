using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class ConcursoEspecial : ConcursoBase
    {
        public List<ConcursoEspecialResultado> Numeros { get; set; }
    }

    public class ConcursoEspecialResultado 
    {
        public string NumeroEspecial { get; set; }
        public string Bonus { get; set; }
    }

}
