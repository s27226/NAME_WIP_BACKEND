
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class LoginController : ControllerBase
    {
        public class LoginRequest
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpPost]
        public IActionResult Post([FromBody] LoginRequest request)
        {
            if (request.Username == "admin" && request.Password == "password")
            {
                return Ok($"Witaj, {request.Username}");
            }

            return Unauthorized("Niepoprawne dane");
        }
    }
    
    
}