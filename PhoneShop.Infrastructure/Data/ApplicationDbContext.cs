using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneShop.Infrastructure.Data.Models;

namespace PhoneShop.Infrastructure.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        internal DbSet<CartItem> CartItems { get; set; }
        internal DbSet<Phone> Phones { get; set; }
        internal DbSet<Brand> Brands { get; set; }
    }
}
