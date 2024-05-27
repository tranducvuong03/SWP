﻿using DiamondShop.Data;
namespace DiamondShop.Model
{


    public class OrderModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
