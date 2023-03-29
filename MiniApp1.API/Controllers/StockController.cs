using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MiniApp1.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetStock()
        {
            var userName = HttpContext.User.Identity.Name;  // token içerisinden kullanıcıya ait isim alınabilir
            var userIdClaim = User.Claims.FirstOrDefault(x=> x.Type == ClaimTypes.NameIdentifier); // token içerisinden user id alınabilir. string gelir

            return Ok($"Stock -> UserName: {userName} - UserId: {userIdClaim.Value}");
        }
    }
}
