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
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("leidsa")]
        public async Task<ActionResult> GetLoteriaLeisa()
        {
            var response = await _loteriaServices.GetLoteriaLeisaAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("anguila")]
        public async Task<ActionResult> GetLoteriaAnguila()
        {
            var response = await _loteriaServices.GetLoteriaAnguilaAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("kingLottery")]
        public async Task<ActionResult> GetLoteriaKingLottery()
        {
            var response = await _loteriaServices.GetLoteriaKingLotteryAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("americanas")]
        public async Task<ActionResult> GetLoteriaAmericana()
        {
            var response = await _loteriaServices.GetLoteriaAmericanaAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("laSuerte")]
        public async Task<ActionResult> GetLoteriaLaSuerte()
        {
            var response = await _loteriaServices.GetLoteriaLaSuerteAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("loteDom")]
        public async Task<ActionResult> GetLoteriaLoteDom()
        {
            var response = await _loteriaServices.GetLoteriaLoteDomAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("loteka")]
        public async Task<ActionResult> GetLoteriaLoteka()
        {
            var response = await _loteriaServices.GetLoteriaLotekaAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [HttpGet("primera")]
        public async Task<ActionResult> GetLoteriaPrimera()
        {
            var response = await _loteriaServices.GetLoteriaPrimeraAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }
        [HttpGet("real")]
        public async Task<ActionResult> GetLoteriaReal()
        {
            var response = await _loteriaServices.GetLoteriaRealAsync();
            if (response.Data != null) return BadRequest(response);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }
    }
}
