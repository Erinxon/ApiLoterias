﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Models
{
    public class Concurso : ConcursoBase
    {
        public string[] Numeros { get; set; }
    }
}
