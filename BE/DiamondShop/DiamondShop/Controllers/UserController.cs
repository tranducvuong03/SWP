using DiamondShop.Model;
using DiamondShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FAMS.Entities.Data;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DiamondDbContext _context;

        public UserController(DiamondDbContext context)
        {
            _context = context;
        }

		[HttpPost("Login")]
		public async Task<IActionResult> Login(string username)
        {
            var user = await _context.Users.FindAsync(username);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }

        
    }
}

