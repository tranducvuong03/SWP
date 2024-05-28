using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class Category
    {
        [Key]
		[Required]
		public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = null!;
        [ForeignKey("Product")]

        public virtual ICollection<Product> Products { get; set; }
    }
}