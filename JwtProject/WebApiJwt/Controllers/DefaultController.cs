using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Test()
        {
            return Ok(new CreateToken().TokenCraete());
        }

        [HttpGet("[action]")]
        public IActionResult TestAdmin()
        {
            return Ok(new CreateToken().TokenCraeteAdmin());
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Test2()
        {
            return Ok("Welcome");
        }

        [Authorize(Roles ="Admin, Visitor")]
        [HttpGet("[action]")]
        public IActionResult Test3()
        {
            return Ok("Welcome");
        }
    }
}
