using Microsoft.EntityFrameworkCore;

namespace MiscellaneousApi.Models
{
    public class MiscellaneousDbContext(DbContextOptions<MiscellaneousDbContext> options) : DbContext(options)
    {
        public DbSet<TaxCalculatorItem> TaxCalculatorItems { get; set; }
        public DbSet<ImageInfoItem> ImageInfoItems { get; set; }
    }
}
