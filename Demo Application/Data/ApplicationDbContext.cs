using Demo_Application.Model;
using Microsoft.EntityFrameworkCore;

namespace Demo_Application.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
