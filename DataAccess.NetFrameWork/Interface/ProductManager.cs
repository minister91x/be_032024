using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork.Interface
{
    public class ProductManager : IProductManager
    {
        public List<Product> GetAllProducts()
        {
            return GetProducts();
        }

        public int ProductInsertUpdate(Product product)
        {
            try
            {
                if (product == null
                    || string.IsNullOrEmpty(product.Name)
                    || product.Price <= 0 ||
                    product.Id <= 0)
                {
                    return -1;
                }

                // Check bảo mật ( có ký tự đặc biệt không , có javascript không , có thẻ html không)

                if (!CommonLibs.Sercurity.HasXssFilterChars(product.Name))
                {
                    return -2;
                }

                var list = GetAllProducts();
                list.Add(product);
                return 1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int Product_Delete(int ProductID)
        {
            try
            {
                // Bước 1: Check dữ liệu 

                if (ProductID <= 0)
                {
                    return -1;
                }

                // Bước 2: check sản phẩm theo id truyền vào có không

                var list = GetAllProducts();
                var product = new Product();

                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        if (item.Id == ProductID)
                        {
                            product.Id = item.Id;
                            product.Name = item.Name;
                            break;
                        }
                    }
                }


                if (product.Id <= 0)
                {
                    return -2;
                }


                // Bước 3: thực hiện xóa

                list.Remove(product);

                return 1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public int test()
        {
            throw new NotImplementedException();
        }

        private List<Product> GetProducts()
        {
            var list = new List<Product>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    list.Add(new Product { Id = i, Name = "Product " + i, Price = 10 + i });
                }

                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
