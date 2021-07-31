using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Loteka
    {
        public TipoConcurso TocaTres { get; set; }
        public TipoConcurso QuinielaLoteka { get; set; }
        public TipoConcurso MegaChances { get; set; }    
        public TipoConcurso MegaChancesRepartidera { get; set; }
        public TipoConcurso ElExtra { get; set; }
        public TipoConcurso MegaLotto { get; set; }
    }
}
