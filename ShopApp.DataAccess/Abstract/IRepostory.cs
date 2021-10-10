using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccess.Abstract
{
  public  interface IRepostory<T>
    {
        T GetById(int id);
        T GetOne(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);


        void Create(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}
