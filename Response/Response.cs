using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Response
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; } = true;
        public string message { get; set; }
    }
}
