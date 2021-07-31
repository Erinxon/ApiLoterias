using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Nacional
    {
        public TipoConcurso JuegaPega { get; set; }
        public TipoConcurso GanaMas { get; set; }
        public TipoConcurso LoteriaNacional { get; set; }
        public TipoConcurso BilletesJueves { get; set; }
        public TipoConcurso BilletesDomingo { get; set; }
    }
}
