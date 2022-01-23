using Microsoft.EntityFrameworkCore;
using POCApp.Models;

namespace POCApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
