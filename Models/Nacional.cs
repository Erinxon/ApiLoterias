using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Nacional
    {
        public Concurso JuegaPega { get; set; }
        public Concurso GanaMas { get; set; }
        public Concurso LoteriaNacional { get; set; }
        public ConcursoEspecial BilletesJueves { get; set; }
        public ConcursoEspecial BilletesDomingo { get; set; }
    }
}
