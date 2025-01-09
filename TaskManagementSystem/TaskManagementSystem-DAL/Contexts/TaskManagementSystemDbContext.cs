using Microsoft.EntityFrameworkCore;
using TaskManagementSystem_Core.Entities;

namespace TaskManagementSystem_DAL.Contexts
{
    public class TaskManagementSystemDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public TaskManagementSystemDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementSystemDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
