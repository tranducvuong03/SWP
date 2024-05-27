﻿using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = null!;

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}