using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Nacional
    {
        public Sorteo JuegaPega { get; set; }
        public Sorteo GanaMas { get; set; }
        public Sorteo LoteriaNacional { get; set; }
        public SorteoEspecial BilletesJueves { get; set; }
        public SorteoEspecial BilletesDomingo { get; set; }
    }
}
