using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Warranty
    {
        [Key]
        public int WarrantyId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public int WarrantyPeriod { get; set; }
    }
}