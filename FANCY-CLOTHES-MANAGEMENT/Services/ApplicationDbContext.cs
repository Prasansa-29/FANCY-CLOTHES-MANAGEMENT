using FANCY_CLOTHES_MANAGEMENT.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FANCY_CLOTHES_MANAGEMENT.Services
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var Merchant = new IdentityRole("Merchant");
            Merchant.NormalizedName = "Merchant";

            var Customer = new IdentityRole("Customer");
            Customer.NormalizedName = "Customer";


            builder.Entity<IdentityRole>().HasData(Merchant, Customer);
        }
    }
}
