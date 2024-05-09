using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneShop.Infrastructure.Data.Models
{
    internal class CartItem : BaseEntity
    {
        public string UserId { get; set; } = null!;

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int PhoneId { get; set; }
        [ForeignKey(nameof(PhoneId))]

        public virtual Phone Phone { get; set; }
    }
}
