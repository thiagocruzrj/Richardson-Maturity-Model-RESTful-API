using Microsoft.EntityFrameworkCore;

namespace PeopleRegAPI.Model.context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {
            
        }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
            
        }

        public DbSet<Person> People { get; set; }
    }
}