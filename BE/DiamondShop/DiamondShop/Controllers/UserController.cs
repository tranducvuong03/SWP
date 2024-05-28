using DiamondShop.Model;
using DiamondShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FAMS.Entities.Data;

namespace DiamondShop.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DiamondDbContext _context;

        public UserController(DiamondDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            
            var user = _context.Users.ToList();
            return Ok(user);
        }

        
    }
}

