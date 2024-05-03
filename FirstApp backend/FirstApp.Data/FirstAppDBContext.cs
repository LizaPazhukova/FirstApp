using FirstApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Data
{
    public class FirstAppDBContext : DbContext
    {
        public FirstAppDBContext(DbContextOptions options) : base(options) { }
        public DbSet<List>? Lists { get; set; }
        public DbSet<Card>? Cards { get; set; }
        public DbSet<ActivityLog>? ActivityLogs { get; set; }

    }
}