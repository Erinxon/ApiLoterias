using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class LoteDom
    {
        public Sorteo Quiniela { get; set; }
        public Sorteo ElQuemaitoMayor { get; set; }
        public Sorteo SuperPale { get; set; }
        public Sorteo AgarraCuatro { get; set; }
    }
}
