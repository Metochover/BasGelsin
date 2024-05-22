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
    public class MenuRepo : IMenuDal
    {
        Context c = new Context();
        public void AddMenu(Menu menu)
        {
            c.Add(menu);
            c.SaveChanges();
        }

        public void Delete(Menu item)
        {
            throw new NotImplementedException();
        }

        public Menu GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetListAll()
        {
            throw new NotImplementedException();
        }

        public Menu GetMenu(int id)
        {
            return c.Menus.Find(id);
        }

        public void Insert(Menu item)
        {
            throw new NotImplementedException();
        }

        public List<Menu> ListAllMenu()
        {
            return c.Menus.ToList();
        }

        public void RemoveMenu(Menu menu)
        {
            c.Remove(menu);
            c.SaveChanges();

        }

        public void Update(Menu item)
        {
            throw new NotImplementedException();
        }

        public void UpdateMenu(Menu menu)
        {
            c.Update(menu);
            c.SaveChanges();

        }
    }
}
