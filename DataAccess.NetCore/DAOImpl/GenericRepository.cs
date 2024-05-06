using DataAccess.NetCore.DAO;
using DataAccess.NetCore.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DAOImpl
{
    public class GenericRepository<T> : IGenericRepository<T>
    {
        private EShopDbContext _eShopDbContext;

        public GenericRepository(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public void Add(T entity)
        {
            _eShopDbContext.Add(entity);
        }
    }
}
