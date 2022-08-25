using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var delete = new Context();
            delete.Remove(t);
            delete.SaveChanges();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            using var getByFilter = new Context();
            return getByFilter.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            using var getByID = new Context();
            return getByID.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var getList = new Context();
            return getList.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var insert = new Context();
            insert.Add(t);
            insert.SaveChanges();
        }

        public void Update(T t)
        {
            using var update = new Context();
            update.Update(t);
            update.SaveChanges();
        }
    }
}
