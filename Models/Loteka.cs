using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Loteka
    {
        public Sorteo TocaTres { get; set; }
        public Sorteo QuinielaLoteka { get; set; }
        public Sorteo MegaChances { get; set; }    
        public Sorteo MegaChancesRepartidera { get; set; }
        public Sorteo ElExtra { get; set; }
        public Sorteo MegaLotto { get; set; }
    }
}
