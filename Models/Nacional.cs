using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Nacional
    {
        public List<Sorteo> Sorteos { get; set; }
        public List<SorteoEspecial> SorteoEspeciales { get; set; }
    }
}
