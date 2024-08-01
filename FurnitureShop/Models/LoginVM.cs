using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Models
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur")]
        [Display(Name = "Kullanıcı adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre gereklidir")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakterden oluşmalıdır")]
        public string Password { get; set; }
    }
}
