using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class KingLottery
    {
        public Concurso PickTresDia { get; set; }
        public Concurso PickCuatroDia { get; set; }
        public Concurso QuinielaDoceTrenta { get; set; }
        public Concurso PhilipsburgMedioDia { get; set; }
        public Concurso LotoPoolMedioDia { get; set; }
        public Concurso PickTresNoche { get; set; }
        public Concurso PickCuatroNoche { get; set; }
        public Concurso QuinielaSieteTrenta { get; set; }
        public Concurso PhilipsburgNoche { get; set; }
        public Concurso LotoPoolNoche { get; set; }
    }
}
