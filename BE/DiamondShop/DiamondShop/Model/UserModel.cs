using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Model
{
	public class UserModel
	{
		public string UserId { get; set; }
		public int RoleId { get; set; }
		public int CartId { get; set; }
		public string? Email { get; set; }
		public string? Status { get; set; }
		public string? FullName { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public bool IsActive { get; set; }
	}
}
