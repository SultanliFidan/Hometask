using GenericRepository.Entites;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Contexts
{
    public class AppDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public AppDbContext(DbContextOptions opt) : base(opt)
        {
        }

        


    }
}
