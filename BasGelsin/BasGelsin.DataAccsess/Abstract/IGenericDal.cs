﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasGelsin.DataAccsess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert (T item);
        void Update (T item);
        void Delete (T item);
        List<T> GetListAll ();
        T GetById (int id);

    }
}
