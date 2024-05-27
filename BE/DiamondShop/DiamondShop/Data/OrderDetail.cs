using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}