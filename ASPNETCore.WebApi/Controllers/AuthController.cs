using ASPNETCore.WebApi.Services;
using Microsoft.AspNetCore.Mvc;


namespace ASPNETCore.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password) 
        {
        if (username == "api" && password == "2024")
            {
                var token = TokenService.GenerateToken(new Models.Tbaluno());
                return Ok(token);
            }

            return BadRequest("Usuario ou Senha invalida");
        }
    }
}
