using DapperAndEntityFrameWorkCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace DapperAndEntityFrameWorkCourse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().Ignore(u => u.Employees);
            modelBuilder.Entity<Employee>().HasOne(u => u.Company).WithMany(u => u.Employees).HasForeignKey(fk => fk.CompanyId);
        }
    }
}
