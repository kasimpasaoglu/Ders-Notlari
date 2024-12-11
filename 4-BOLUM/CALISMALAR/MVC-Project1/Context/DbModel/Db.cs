using DMO;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class Db : DbContext
    {
        public DbSet<Login> Logins { get; set; }
        public DbSet<Student> Students { get; set; }
        public Db(DbContextOptions<Db> options) : base(options)
        {
        }
    }
}