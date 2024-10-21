using Microsoft.EntityFrameworkCore;

namespace WebAPI.DataAccessLayer
{
    public class ContextAPI : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=CoreBlogApiDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
