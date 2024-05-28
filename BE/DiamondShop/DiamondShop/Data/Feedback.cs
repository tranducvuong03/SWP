﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Feedback
    {
        [Key]
        [Required]
        public int FeedbackId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public string? Description { get; set; }

		public virtual User User { get; set; }
		public virtual Product Product { get; set; }
	}
}