using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class SorteoEspecial : SorteoBase
    {
        [JsonProperty(Order = 3)]
        public List<SorteoEspecialResultado> Numeros { get; set; }
    }

    public class SorteoEspecialResultado
    {
        public string NumeroEspecial { get; set; }
        public string Bonus { get; set; }
    }

}
