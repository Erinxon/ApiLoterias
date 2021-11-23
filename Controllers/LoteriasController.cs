using ApiLoteria.Models;
using ApiLoteria.Response;
using ApiLoteria.Services;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        [HttpGet]
        public async Task<ActionResult<Response<Loteria>>> GetAllLoterias()
        {
            var response = new Response<Loteria>();
            try
            {
                var nacional = await _loteriaServices.GetLoteriaNacionalAsync();
                var leisa = await _loteriaServices.GetLoteriaLeisaAsync();
                var anguila = await _loteriaServices.GetLoteriaAnguilaAsync();
                var kingLottery = await _loteriaServices.GetLoteriaKingLotteryAsync();
                var americanas = await _loteriaServices.GetLoteriaAmericanaAsync();
                var suerte = await _loteriaServices.GetLoteriaLaSuerteAsync();
                var loteDom = await _loteriaServices.GetLoteriaLoteDomAsync();
                var loteka = await _loteriaServices.GetLoteriaLotekaAsync();
                var primera = await _loteriaServices.GetLoteriaPrimeraAsync();
                var real = await _loteriaServices.GetLoteriaRealAsync();

                var loterias = new Loteria() { 
                    Nacional = nacional.Data,
                    Leidsa = leisa.Data,
                    Real = real.Data,
                    LoteDom = loteDom.Data,
                    Loteka = loteka.Data,
                    Anguila = anguila.Data,
                    KingLottery = kingLottery.Data,
                    Americanas = americanas.Data,
                    LaSuerte = suerte.Data,
                    LaPrimera = primera.Data,
                };
                response.Data = loterias;

            }
            catch (Exception ex)
            {
                response.Success = false;
                response.message = ex.Message;
            }
            return !response.Success || response.Data == null ?
                  BadRequest(response) :
                  Ok(response);
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
