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
    public class ProductRepository : IProductRepository
    {
        private EShopDbContext _eShopDbContext;
        public ProductRepository(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public void ProductInsert(Product product)
        {
            _eShopDbContext.product.Add(product);
        }
    }
}
