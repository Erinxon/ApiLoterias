using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Loteka
    {
        public Concurso TocaTres { get; set; }
        public Concurso QuinielaLoteka { get; set; }
        public Concurso MegaChances { get; set; }    
        public Concurso MegaChancesRepartidera { get; set; }
        public Concurso ElExtra { get; set; }
        public Concurso MegaLotto { get; set; }
    }
}
