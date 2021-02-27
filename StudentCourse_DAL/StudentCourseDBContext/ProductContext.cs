using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Product_DAL.Models;

namespace CourseProduct_DAL.ProductDBContext
{
    public class ProductContext : DbContext
    {

        public ProductContext(DbContextOptions options)
      : base(options)
        {
        }

       
        public DbSet<Product> Products { get; set; }
 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
