using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class ShoppingCart
    {
        [Key]
        public int CartId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}