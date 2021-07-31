using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class LoteDom
    {
        public TipoConcurso Quiniela { get; set; }
        public TipoConcurso ElQuemaitoMayor { get; set; }
        public TipoConcurso SuperPale { get; set; }
        public TipoConcurso AgarraCuatro { get; set; }
    }
}
