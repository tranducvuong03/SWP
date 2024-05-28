using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        
        [ForeignKey("ProductDetail")]
        public int ProductDetailId { get; set; }
        
        [ForeignKey("Certificate")]
        public int CertificateId { get; set; }

		[StringLength(300)]
		public string? Description { get; internal set; }
		public int Stock { get; set; }

		[StringLength(50)]
		public string Status { get; set; } = null!;

		public virtual Category Category { get; set; } = null!;
		public virtual ProductDetail ProductDetail { get; set; } = null!;
		public virtual Certificate Certificate { get; set; } = null!;

		public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
