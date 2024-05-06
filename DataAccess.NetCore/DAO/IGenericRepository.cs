﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DAO
{
    public interface IGenericRepository<T>
    {
        void Add(T entity);
    }
}
