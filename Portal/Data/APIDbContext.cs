using Microsoft.EntityFrameworkCore;
using Portal.Models;

namespace Portal.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
