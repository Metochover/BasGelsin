using BasGelsin.DataAccsess.Abstract;
using BasGelsin.DataAccsess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.DataAccsess.Repositories
{
    public class GenericRepo<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Delete(T item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return c.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            c.Add(item);
            c.SaveChanges();
        }

        public void Update(T item)
        {
            c.Update(item);
            c.SaveChanges();
        }
    }
}
