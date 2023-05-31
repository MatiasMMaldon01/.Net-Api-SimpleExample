using Curso_API_con_.Net.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace Curso_API_con_.Net.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
