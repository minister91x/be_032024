using DataAccess.NetCore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IPostRepository _postRepository { get; set; }
        public IProductRepository _productRepository { get; set; }

        public IProductGenerictRepository _productGenerictRepository { get;set; }

        public IUserRepository _userRepository { get; set; }
        int SaveChange();
    }
}
