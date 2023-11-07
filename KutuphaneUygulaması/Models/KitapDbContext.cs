using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Models
{
    public class KitapDbContext : DbContext
    {

        public KitapDbContext(DbContextOptions<KitapDbContext> options) : base(options)
        {

        }

        public DbSet<Kitap> kitaplar { get; set; }
    }
}
