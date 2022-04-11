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
    }
}
