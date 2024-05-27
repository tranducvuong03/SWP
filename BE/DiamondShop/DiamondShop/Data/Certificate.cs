using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Certificate
    {
        [Key]
        public int CertificateId { get; set; }

        public decimal CaratWeight { get; set; }
        public string Color { get; set; } = null!;
        public string Clarity { get; set; } = null!;
        public string Cut { get; set; } = null!;

        // Thêm trường ProductId để lưu trữ khóa ngoại của Product
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}