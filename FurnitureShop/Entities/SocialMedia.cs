using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class SocialMedia
    {
        [Key]
        public int SocialMediaId { get; set; }

        [StringLength(1000)]
        [Display(Name = "İkon")]
        public string? Icon { get; set; }

        [StringLength(50)]
        [Display(Name = "Sosyal Medya Adı")]
        public string Name { get; set; }

        [StringLength(1000)]
        [Display(Name = "Link")]
        public string? Url { get; set; }
    }
}
