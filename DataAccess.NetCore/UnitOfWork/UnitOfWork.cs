using DataAccess.NetCore.DAO;
using DataAccess.NetCore.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private EShopDbContext _dbContext;
        public IPostRepository _postRepository { get; set; }
        public IProductRepository _productRepository { get; set; }
        public IProductGenerictRepository _productGenerictRepository { get; set; }
        public IUserRepository _userRepository { get; set; }

        public UnitOfWork(EShopDbContext dbContext, IPostRepository postRepository,
            IProductRepository productRepository, 
            IProductGenerictRepository productGenerictRepository, IUserRepository userRepository)
        {
            _dbContext = dbContext;
            _postRepository = postRepository;
            _productRepository = productRepository;
            _productGenerictRepository = productGenerictRepository;
            _userRepository = userRepository;
        }

        public int SaveChange()
        {
           return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
