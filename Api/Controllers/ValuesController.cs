using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("IsWorking")]
        public IActionResult IsWorking()
        {
            return Ok("Yes");
        }

    }
}