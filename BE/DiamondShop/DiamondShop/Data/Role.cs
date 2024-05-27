using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [Required]
        public string RoleName { get; set; } = null!;

        // Quan hệ 1-n với User
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}