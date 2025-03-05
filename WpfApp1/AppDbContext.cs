using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Addtransactions> Addtransactions { get; set; }
        public DbSet<Addcategory> Addcategory { get; set; }
        public DbSet<profile> profile { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=C:\\Users\\MSI\\Downloads\\New folder\\app.db");
        }
    }
}
