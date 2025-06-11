using Microsoft.EntityFrameworkCore;
using Lms.Models; 
using Lms.Models; 

namespace Lms.Data
{
    public class LmsDbContext : DbContext
    {
        public LmsDbContext(DbContextOptions<LmsDbContext> options)
            : base(options)
        {
        }

        public DbSet<NotificationTemplate> NotificationTemplates { get; set; }
    }
}
