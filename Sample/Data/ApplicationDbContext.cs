using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sample.Models;

namespace Sample.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserAccount, IdentityRole<long>, long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sample.Models.Movie> Movie { get; set; } = default!;
    }
}
