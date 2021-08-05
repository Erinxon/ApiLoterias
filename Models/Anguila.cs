using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Anguila
    {
        public Sorteo AnguilaDiesAM { get; set; }
        public Sorteo AnguilaUnaPM { get; set; }
        public Sorteo AnguilaCincoPM { get; set; }
        public Sorteo AnguilaNuevePM { get; set; }
    }
}
