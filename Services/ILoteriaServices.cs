using ApiLoteria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Services
{
    public interface ILoteriaServices
    {
        Task<Nacional> GetLoteriaNacionalAsync();
    }
}
