using ApiLoteria.Models;
using ApiLoteria.Response;
using ApiLoteria.Services;
using HtmlAgilityPack;
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
        public async Task<ActionResult<Response<Nacional>>> GetLoteriaNacional()
        {
            var response = await _loteriaServices.GetLoteriaNacionalAsync();
            return !response.Success || response.Data == null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("leidsa")]
        public async Task<ActionResult<Response<Leidsa>>> GetLoteriaLeisa()
        {
            var response = await _loteriaServices.GetLoteriaLeisaAsync();
            return !response.Success || response.Data == null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("anguila")]
        public async Task<ActionResult<Response<Anguila>>> GetLoteriaAnguila()
        {
            var response = await _loteriaServices.GetLoteriaAnguilaAsync();
            return !response.Success || response.Data == null ?
                  BadRequest(response) :
                  Ok(response);
        }

        [HttpGet("kingLottery")]
        public async Task<ActionResult<Response<KingLottery>>> GetLoteriaKingLottery()
        {
            var response = await _loteriaServices.GetLoteriaKingLotteryAsync();
            return !response.Success || response.Data == null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("americanas")]
        public async Task<ActionResult<Response<Americanas>>> GetLoteriaAmericana()
        {
            var response = await _loteriaServices.GetLoteriaAmericanaAsync();
            return !response.Success || response.Data == null ?
                  BadRequest(response) :
                  Ok(response);
        }

        [HttpGet("laSuerte")]
        public async Task<ActionResult<Response<LaSuerte>>> GetLoteriaLaSuerte()
        {
            var response = await _loteriaServices.GetLoteriaLaSuerteAsync();
            return !response.Success || response.Data == null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("loteDom")]
        public async Task<ActionResult<Response<LoteDom>>> GetLoteriaLoteDom()
        {
            var response = await _loteriaServices.GetLoteriaLoteDomAsync();
            return !response.Success || response.Data == null ?
                  BadRequest(response) :
                  Ok(response);
        }

        [HttpGet("loteka")]
        public async Task<ActionResult<Response<Loteka>>> GetLoteriaLoteka()
        {
            var response = await _loteriaServices.GetLoteriaLotekaAsync();
            return !response.Success || response.Data == null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("primera")]
        public async Task<ActionResult<Response<Primera>>> GetLoteriaPrimera()
        {
            var response = await _loteriaServices.GetLoteriaPrimeraAsync();
            return !response.Success || response.Data == null ?
                 BadRequest(response) :
                 Ok(response);
        }

        [HttpGet("real")]
        public async Task<ActionResult<Response<Real>>> GetLoteriaReal()
        {
            var response = await _loteriaServices.GetLoteriaRealAsync();
            return !response.Success || response.Data == null ?
                  BadRequest(response) :
                  Ok(response);
        }


    }
}
