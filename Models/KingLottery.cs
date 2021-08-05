using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class KingLottery
    {
        public Sorteo PickTresDia { get; set; }
        public Sorteo PickCuatroDia { get; set; }
        public Sorteo QuinielaDoceTrenta { get; set; }
        public Sorteo PhilipsburgMedioDia { get; set; }
        public Sorteo LotoPoolMedioDia { get; set; }
        public Sorteo PickTresNoche { get; set; }
        public Sorteo PickCuatroNoche { get; set; }
        public Sorteo QuinielaSieteTrenta { get; set; }
        public Sorteo PhilipsburgNoche { get; set; }
        public Sorteo LotoPoolNoche { get; set; }
    }
}
