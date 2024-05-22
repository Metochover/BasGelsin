using BasGelsin.Data.Concrete;
using BasGelsin.DataAccsess.Abstract;
using BasGelsin.DataAccsess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.DataAccsess.EntityFramework
{
    public class EfUserRepo:GenericRepo<User>,IUserDal
    {
    }
}
