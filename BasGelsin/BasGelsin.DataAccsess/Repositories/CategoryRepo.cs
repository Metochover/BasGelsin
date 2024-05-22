using BasGelsin.Data.Concrete;
using BasGelsin.DataAccsess.Abstract;
using BasGelsin.DataAccsess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.DataAccsess.Repositories
{
    public class CategoryRepo : ICategoryDal
    {
        Context c = new Context();

        public void Delete(Category item)
        {
            c.Remove(item);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> GetListAll()
        {
            return c.Categories.ToList();
        }

        public void Insert(Category item)
        {
            c.Add(item);
        }

        public void Update(Category item)
        {
            c.Update(item);
        }
    }
}
