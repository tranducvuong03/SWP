namespace DiamondShop.Model
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string UserName { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public List<OrderViewModel> OrderDetails { get; set; } = new List<OrderViewModel>();
    }


}
