using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
   public interface IProductDal
    {
        Product GetById(int id);
        Product GetOne(Expression<Func<Product, bool>> filter);
        IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter);


        void Create(Product entitiy);
        void Update(Product entitiy);
        void Delete(Product entitiy);
       
    }
}
