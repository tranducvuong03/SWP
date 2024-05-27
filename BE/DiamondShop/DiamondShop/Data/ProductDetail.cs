using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }
        public string Origin { get; set; } = null!;
        public decimal Carat { get; set; }
        public string Clarity { get; set; } = null!;
        public string Cut { get; set; } = null!;
        public string Color { get; set; } = null!;
    }
}