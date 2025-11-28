using Microsoft.EntityFrameworkCore;

namespace SQLProject.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        public DbSet<SalesData> sales_data { get; set; }


    }
}
