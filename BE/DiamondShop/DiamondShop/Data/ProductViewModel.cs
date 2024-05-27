namespace DiamondShop.Data
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? Description { get; set; }
        public int Stock { get; set; }
        public string Origin { get; set; } = null!;
        public decimal Carat { get; set; }
        public string Clarity { get; set; } = null!;
        public string Cut { get; set; } = null!;
        public string Color { get; set; } = null!;
    }
}
