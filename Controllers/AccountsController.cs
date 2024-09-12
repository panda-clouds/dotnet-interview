using System.Security.Claims;
using autoChecker.Database;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_interview.Controllers
{
    [ApiController]
    [Route("api/Accounts")]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // public async Task<ActionResult> Login(string email, string password){
        //     var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);
        //     if(user != null){
        //         var claims = new List<Claim>{
        //             new Claim(ClaimTypes.Name, user.Email),
        //             new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
        //         };

        //         var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //         var authProperies = new AuthenticationProperties{
        //             IsPersistent = true
        //         };

        //         await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity), authProperies);
        //         return Ok();
        //     }
        //     return BadRequest("Not found");
        // }

    }
}