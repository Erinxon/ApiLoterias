using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class KingLottery
    {
        public TipoConcurso PickTresDia { get; set; }
        public TipoConcurso PickCuatroDia { get; set; }
        public TipoConcurso QuinielaDoceTrenta { get; set; }
        public TipoConcurso PhilipsburgMedioDia { get; set; }
        public TipoConcurso LotoPoolMedioDia { get; set; }
        public TipoConcurso PickTresNoche { get; set; }
        public TipoConcurso PickCuatroNoche { get; set; }
        public TipoConcurso QuinielaSieteTrenta { get; set; }
        public TipoConcurso PhilipsburgNoche { get; set; }
        public TipoConcurso LotoPoolNoche { get; set; }
    }
}
