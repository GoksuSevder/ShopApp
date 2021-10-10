using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContex();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }
        private static Category[] Categories =
            {
            new Category() {Name="Telefon" },
            new Category() { Name="Bilgisayar"},
            };
        private static Product[] Products =
        {
            new Product () {Name="Samsung6",ImageUrl="1.jpg",Price=1000},
            new Product () {Name="Samsung7",ImageUrl="2.jpg",Price=2000},
            new Product () {Name="Samsung8",ImageUrl="3.jpg",Price=3000},
            new Product () {Name="Samsung9",ImageUrl="4.jpg",Price=4000},
                       
        };
    }
}
