using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DTO
{
    public class Post
    {
        public int PostID { get; set; }
        public string PostName { get; set; }
    }

    public class GetListPostRequestData
    {
        public string? PostName { get; set; }
    }
}
