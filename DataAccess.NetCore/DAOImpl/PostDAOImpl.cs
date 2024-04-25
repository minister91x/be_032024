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
    public class PostDAOImpl : IPostDAO
    {
        private EShopDbContext _dbContext;
        public PostDAOImpl(EShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Post>> GetPost(GetListPostRequestData requestData)
        {
            var list = new List<Post>();
            try
            {
                //await Task.Yield();
                //for (int i = 0; i < 5; i++)
                //{
                //    list.Add(new Post { PostID = i, PostName = "PostName_" + i });
                //}

                list = _dbContext.post.ToList();
                if (!string.IsNullOrEmpty(requestData.PostName))
                {
                    list = list.FindAll(s => s.PostName.ToLower().Contains(requestData.PostName));
                }
            }
            catch (Exception EX)
            {

                throw;
            }

            return list;
        }
    }
}
