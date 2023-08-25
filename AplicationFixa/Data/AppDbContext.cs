using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AplicationFixa.Models;

namespace AplicationFixa.Data
{
    public class AppDbContext :
        IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Psicologo>? psicologos{ get; set; }

    }
}
