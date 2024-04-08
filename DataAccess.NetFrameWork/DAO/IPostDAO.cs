using DataAccess.NetFrameWork.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork.Interface
{
    public interface IPostDAO
    {
        List<Post> GetPosts();
        int Post_Insert(Post post);
    }
}
