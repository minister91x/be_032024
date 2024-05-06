using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DTO
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public string FullName { get; set; }
        public int IsAdmin { get; set; }

        public string refeshtoken { get; set; }
        public DateTime RefreshTokenExpired { get; set; }
    }

    public class UserLogin_RequestData
    {
        public string UserName { get; set; }
        public string UserPass { get; set; }
    }

    public class UpdateRefreshTokenExpired_RequestData
    {
        public int UserID { get; set; }
        public string refeshtoken { get; set; }
        public DateTime RefreshTokenExpired { get; set; }
    }
}
