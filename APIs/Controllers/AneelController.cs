using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_ANEEL.Models;
using Api_ANEEL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_ANEEL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AneelController : ControllerBase
    {
        private readonly AneelServices _aneelServices;

        public AneelController(AneelServices aneelServices)
        {
            _aneelServices = aneelServices;
        }
        [HttpGet("bandeiras")]
        public ActionResult<IEnumerable<Bandeira>> GetBandeiras()
        {
            var resultado = _aneelServices.GetBandeiras();
            return resultado;
        }
    }
}
