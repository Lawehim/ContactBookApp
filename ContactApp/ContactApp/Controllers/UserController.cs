using ContactApp.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    { 
        [HttpGet]
        public async Task<IActionResult> Login([FromBody] LoginDTO model)
        {
            return Ok();
        }
    }
}
