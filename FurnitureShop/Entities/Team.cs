using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [StringLength(50)]
        [Display(Name = "Ünvan")]
        public string Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageUrl { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

    }
}
