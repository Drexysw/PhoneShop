using System.ComponentModel.DataAnnotations;

namespace PhoneShop.Infrastructure.Data.Models
{
    internal class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
