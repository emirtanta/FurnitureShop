using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class RegisterVM
    {
        

        [Required(ErrorMessage ="Kullanıcı adı zorunludur")]
        [Display(Name ="Kullanıcı adı")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Ad alanı zorunludur")]
        [Display(Name ="Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Soyad alanı zorunludur")]
        [Display(Name ="Soyad")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Email zorunludur")]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Şifre gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Şifre en az 6 karakterden oluşmalıdır")]
        public string Password { get; set; }
    }
}
