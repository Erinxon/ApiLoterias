using ApiLoteria.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLoteria.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 5)]
    public class LoteriasController : ControllerBase
    {
        private readonly ILoteriaServices _loteriaServices;

        public LoteriasController(ILoteriaServices loteriaServices)
        {
            this._loteriaServices = loteriaServices;
        }

        [HttpGet("nacional")]
        public async Task<ActionResult> GetLoteriaNacional()
        {
            var response = await _loteriaServices.GetLoteriaNacionalAsync();
            return !response.Success ?
                BadRequest(response) : response.Data != null ?
                BadRequest(response) :
                Ok(response);
        }

        [HttpGet("leidsa")]
        public async Task<ActionResult> GetLoteriaLeisa()
        {
            var response = await _loteriaServices.GetLoteriaLeisaAsync();
            return !response.Success ?
                 BadRequest(response) : response.Data != null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("anguila")]
        public async Task<ActionResult> GetLoteriaAnguila()
        {
            var response = await _loteriaServices.GetLoteriaAnguilaAsync();
            return !response.Success ?
                 BadRequest(response) : response.Data != null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("kingLottery")]
        public async Task<ActionResult> GetLoteriaKingLottery()
        {
            var response = await _loteriaServices.GetLoteriaKingLotteryAsync();
            return !response.Success ? 
                BadRequest(response) : response.Data != null ? 
                BadRequest(response) : 
                Ok(response);
        }

        [HttpGet("americanas")]
        public async Task<ActionResult> GetLoteriaAmericana()
        {
            var response = await _loteriaServices.GetLoteriaAmericanaAsync();
            return !response.Success ?
                 BadRequest(response) : response.Data != null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("laSuerte")]
        public async Task<ActionResult> GetLoteriaLaSuerte()
        {
            var response = await _loteriaServices.GetLoteriaLaSuerteAsync();
            return !response.Success ?
                BadRequest(response) : response.Data != null ?
                BadRequest(response) :
                Ok(response);
        }

        [HttpGet("loteDom")]
        public async Task<ActionResult> GetLoteriaLoteDom()
        {
            var response = await _loteriaServices.GetLoteriaLoteDomAsync();
            return !response.Success ?
                BadRequest(response) : response.Data != null ?
                BadRequest(response) :
                Ok(response);
        }

        [HttpGet("loteka")]
        public async Task<ActionResult> GetLoteriaLoteka()
        {
            var response = await _loteriaServices.GetLoteriaLotekaAsync();
            return !response.Success ?
                BadRequest(response) : response.Data != null ?
                BadRequest(response) :
                Ok(response);
        }

        [HttpGet("primera")]
        public async Task<ActionResult> GetLoteriaPrimera()
        {
            var response = await _loteriaServices.GetLoteriaPrimeraAsync();
            return !response.Success ?
                BadRequest(response) : response.Data != null ?
                BadRequest(response) :
                Ok(response);
        }
        [HttpGet("real")]
        public async Task<ActionResult> GetLoteriaReal()
        {
            var response = await _loteriaServices.GetLoteriaRealAsync();
            return !response.Success ?
                 BadRequest(response) : response.Data != null ?
                 BadRequest(response) :
                 Ok(response);
        }
    }
}
