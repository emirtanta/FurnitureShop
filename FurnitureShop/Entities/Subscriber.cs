using System.ComponentModel.DataAnnotations;

namespace FurnitureShop.Entities
{
    public class Subscriber
    {
        [Key]
        public int SubscriberId { get; set; }

        [StringLength(50)]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
