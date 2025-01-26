using Microsoft.AspNetCore.Mvc;

namespace TaskManagementAPI.Controllers
{
    [ApiController, Route("/api/[controller]")]

    class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("/login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

    }
}