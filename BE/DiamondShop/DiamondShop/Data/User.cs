using System.ComponentModel.DataAnnotations;
using System.Data;

namespace DiamondShop.Data
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Status { get; set; } = null!;
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string Username { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;

        public Role Role { get; set; } = null!;
        public ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
        public ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
