using Microsoft.EntityFrameworkCore;
using test.API.Properties.Models;
namespace test.API.Properties.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> values { get; set; }
    }
}