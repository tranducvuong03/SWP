using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [ForeignKey("ProductDetail")]
        public int ProductDetailId { get; set; }
        public ProductDetail ProductDetail { get; set; } = null!;

        [ForeignKey("Certificate")]
        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; } = null!;

        public int Stock { get; set; }
        public string Status { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
        public ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
        public string Description { get; internal set; }
    }
}
