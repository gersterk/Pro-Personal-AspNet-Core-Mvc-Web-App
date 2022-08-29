using Jwt_Pro_Personal.DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_Pro_Personal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult LoginToken() //will create a token when we login 
        {
            return Created("", new BuildToken().CreateToken());

        }

        [Authorize]
        [HttpGet("[action]")]

        public IActionResult PageAuthorization()
        {
            return Ok("You are authorized to the authorization page");

        }
    }
}
