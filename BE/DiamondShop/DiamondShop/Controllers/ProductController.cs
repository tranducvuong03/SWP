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

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Select(p => new ProductViewModel
                {
                    ProductId = p.ProductId,
                    CategoryName = p.Category.CategoryName,
                    Status = p.Status,
                    Description = p.Description,
                    Stock = p.Stock,
                    Origin = p.ProductDetail.Origin,
                    Carat = p.ProductDetail.Carat,
                    Clarity = p.ProductDetail.Clarity,
                    Cut = p.ProductDetail.Cut,
                    Color = p.ProductDetail.Color
                })
                .ToListAsync();

            return View(products);
        }
    }
}
