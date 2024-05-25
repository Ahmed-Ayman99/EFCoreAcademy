using EFEssam.Models;
using Microsoft.EntityFrameworkCore;

namespace EFEssam.Data
{
    public class AppDbContext : DbContext
    {
        public  DbSet<Course> Courses { get; set; }
        public  DbSet<Instructor> instructors { get; set; }
        public  DbSet<Office> offices{ get; set; }

        public AppDbContext(DbContextOptions options):base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add All Configs
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);


        }

    }
}
