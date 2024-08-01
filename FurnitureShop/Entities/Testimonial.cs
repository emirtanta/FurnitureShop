using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [StringLength(50)]
        [Display(Name = "Başlık")]
        public string Title { get; set; }

        [StringLength(1000)]
        [Display(Name = "Yorumunuz")]
        public string Comment { get; set; }
    }
}
