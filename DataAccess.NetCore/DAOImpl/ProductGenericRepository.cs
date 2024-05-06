using DataAccess.NetCore.DAO;
using DataAccess.NetCore.DbContext;
using DataAccess.NetCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DAOImpl
{
    public class ProductGenericRepository : GenericRepository<Product>, IProductGenerictRepository
    {
        public ProductGenericRepository(EShopDbContext eShopDbContext) : base(eShopDbContext)
        {
        }
    }
}
