using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevFramework.Northwind.Entities.Concrete
{
        public  class DbStokContext : DbContext
    {
        public DbStokContext()
        {
        }

        public DbStokContext(DbContextOptions<DbStokContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-803QQI1;Database=Products;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
    }
}