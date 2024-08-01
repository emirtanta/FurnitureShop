using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class ContactInfo
    {
        [Key]
        public int ContactInfoId { get; set; }

        [StringLength(1000)]
        [Display(Name = "Resim")]
        public string? ImageUrl { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(15)]
        [Display(Name = "Telefon")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }


        [StringLength(1000)]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
    }
}
