using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [StringLength(1000)]
        [Display(Name = "İkon")]
        public string? Icon { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageUrl { get; set; }
    }
}
