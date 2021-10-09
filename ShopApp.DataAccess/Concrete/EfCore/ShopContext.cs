using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
   public class ShopContex : DbContext
    {
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category>  Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectsV13; Database=ShopDb; integrated securety= true;");
        }
    }
    
}
