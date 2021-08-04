using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class LoteDom
    {
        public Concurso Quiniela { get; set; }
        public Concurso ElQuemaitoMayor { get; set; }
        public Concurso SuperPale { get; set; }
        public Concurso AgarraCuatro { get; set; }
    }
}
