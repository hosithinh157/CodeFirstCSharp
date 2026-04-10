using HoSiThinh_MVC_Test.Models;
using Microsoft.EntityFrameworkCore;
namespace HoSiThinh_MVC_Test.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
