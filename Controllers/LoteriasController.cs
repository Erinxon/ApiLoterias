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
            var loteriaNacional = await _loteriaServices.GetLoteriaNacionalAsync();
            if (loteriaNacional == null) return BadRequest();
            return Ok(loteriaNacional);
        }
    }
}
