using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork.Interface
{
    public interface IProductManager : IDemo
    {
        List<Product> GetAllProducts();
        int ProductInsertUpdate(Product product);
        int Product_Delete(int ProductID);

    }
}
