using ignitech_backend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ignitech_backend.Persistence
{
    public class IgnitechDbContext : DbContext
    {
        public IgnitechDbContext(DbContextOptions<IgnitechDbContext> options) : base(options) { }

        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
