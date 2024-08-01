using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }

        [StringLength(50)]
        [Display(Name ="Başlık")]
        public string Title { get; set; }

        [StringLength(1000)]
        [Display(Name ="Resim 1")]
        public string? Image1 { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim 2")]
        public string? Image2 { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim 3")]
        public string? Image3 { get; set; }

        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}
