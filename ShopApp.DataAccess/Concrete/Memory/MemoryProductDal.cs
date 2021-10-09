using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Id=1,
                    Name= "Samsung s6" ,
                    ImageUrl="1.jpg",
                    Price=100                    
                } ,
                new Product()
                {
                    Id=1,
                    Name= "Samsung s7" ,
                    ImageUrl="2.jpg",
                    Price=200                    
                } ,
                new Product()
                {
                    Id=1,
                    Name= "Samsung s8" ,
                    ImageUrl="3.jpg",
                    Price=300                    
                } ,
                new Product()
                {
                    Id=1,
                    Name= "Samsung s9" ,
                    ImageUrl="4.jpg",
                    Price=4100                    
                }
            };
            return products;
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
