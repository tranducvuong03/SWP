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
            return View();
        }
    }
}

