﻿using ShopApp.DataAccess.Abstract;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : IProductDal
    {
        public void Create(Product entitiy)
        {
            entitiy
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }
        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
        public IQueryable<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

    }
}
