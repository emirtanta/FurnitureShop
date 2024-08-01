using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class UserMessage
    {
        [Key]
        public int UserMessageId { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        [StringLength(50)]
        [Display(Name ="Ad")]
        public string Name { get; set; }

        [StringLength (50)]
        [Display(Name ="Soyad")]
        public string Surname { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [StringLength(1000)]
        [Display(Name ="Mesaj")]
        public string Content { get; set; }
    }
}
