using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Role
    {
		[Key]
		[Required]
		public int roleID { get; set; }
		public string? roleName { get; set; }
	}
}