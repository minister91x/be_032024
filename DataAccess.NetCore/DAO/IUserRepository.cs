using DataAccess.NetCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetCore.DAO
{
    public interface IUserRepository
    {
        Task<User> Login(UserLogin_RequestData requestData);
        Task<int> UpdateRefreshTokenExpired(UpdateRefreshTokenExpired_RequestData requestData);

        Task<Function> GetFunctionByCode(string functioncode);
        Task<UserFunction> UserFunctionGet(int UserId, int FunctionId);
    }
}
