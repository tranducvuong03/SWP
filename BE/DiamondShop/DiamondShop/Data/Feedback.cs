using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}