using Microsoft.EntityFrameworkCore;
using tasks.Entity;
using tasks.Model;

namespace tasks.Data
{
    public class TaskDbContext : DbContext
    {
        public DbSet<Tasking> Tasks { get; set; }

      

        public TaskDbContext(DbContextOptions options)
        : base(options) { }
        
        
    }
}