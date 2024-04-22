using DataAccess.NetCore.DAO;
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
        public async Task<List<Post>> GetPost()
        {
            var list = new List<Post>();
            try
            {
                await Task.Yield();
                for (int i = 0; i < 5; i++)
                {
                    list.Add(new Post { PostID = i, PostName = "PostName_" + i });
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
