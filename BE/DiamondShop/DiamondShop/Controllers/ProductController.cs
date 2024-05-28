using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly DiamondDbContext _context;

        public ProductController(DiamondDbContext context)
        {
            _context = context;
        }

        
    }
}
