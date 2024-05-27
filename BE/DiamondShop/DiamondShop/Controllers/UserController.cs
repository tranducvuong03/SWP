using DiamondShop.Model;
using DiamondShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FAMS.Entities.Data;

namespace DiamondShop.Controllers
{
    public class UserController : Controller
    {
        private readonly DiamondDbContext _context;

        public UserController(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _context.Users
                .Include(u => u.Role)
                .Select(u => new Data.UserViewModel
                {
                    UserId = u.UserId,
                    FullName = u.FullName,
                    Email = u.Email,
                    RoleName = u.Role.RoleName
                })
                .ToListAsync();

            return View(users);
        }
    }
}

