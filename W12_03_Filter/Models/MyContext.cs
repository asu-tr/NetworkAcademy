using System.Data.Entity;

namespace W12_03_Filter.Models
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<MyLog> Logs { get; set; }
    }
}