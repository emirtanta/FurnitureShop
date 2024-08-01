using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Ürün Resmi")]
        public string? ImageUrl { get; set; }

        [StringLength(100)]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }

        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}
