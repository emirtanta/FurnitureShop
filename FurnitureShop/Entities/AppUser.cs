using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class AppUser:IdentityUser<int>
    {
        [StringLength(50)]
        [Display(Name ="Ad")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name ="Soyad")]
        public string Surname { get; set; }

        [StringLength(1000)]
        [Display(Name ="Resim")]
        public string? ImageUrl { get; set; }
    }
}
