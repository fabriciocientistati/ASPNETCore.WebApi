using ASPNETCore.WebApi.Services;
using Microsoft.AspNetCore.Mvc;


namespace ASPNETCore.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password) 
        {
        if (username == "fabricio" && password == "123")
            {
                var token = TokenService.GenerateToken(new Models.Tbaluno());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
