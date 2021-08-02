using ApiLoteria.Models;
using ApiLoteria.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Services
{
    public interface ILoteriaServices 
    {
        Task<Response<Nacional>> GetLoteriaNacionalAsync();
        Task<Response<Leidsa>> GetLoteriaLeisaAsync();
        Task<Response<Real>> GetLoteriaRealAsync();
        Task<Response<Loteka>> GetLoteriaLotekaAsync();
        Task<Response<LoteDom>> GetLoteriaLoteDomAsync();
        Task<Response<Primera>> GetLoteriaPrimeraAsync();
        Task<Response<Americanas>> GetLoteriaAmericanaAsync();
        Task<Response<LaSuerte>> GetLoteriaLaSuerteAsync();
        Task<Response<KingLottery>> GetLoteriaKingLotteryAsync();
        Task<Response<Anguila>> GetLoteriaAnguilaAsync();
    }
}
