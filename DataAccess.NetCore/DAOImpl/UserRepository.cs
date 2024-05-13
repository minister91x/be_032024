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
    public class UserRepository : IUserRepository
    {
        private EShopDbContext _eShopDbContext;
        public UserRepository(EShopDbContext eShopDbContext)
        {
            _eShopDbContext = eShopDbContext;
        }

        public async Task<Function> GetFunctionByCode(string functioncode)
        {
            return _eShopDbContext.function.Where(s => s.FunctionCode == functioncode).FirstOrDefault();
        }

        public async Task<User> Login(UserLogin_RequestData requestData)
        {
            var user = new User();
            try
            {
                user = _eShopDbContext.user.Where(s => s.UserName == requestData.UserName && s.UserPass == requestData.UserPass)
                   .FirstOrDefault();
            }
            catch (Exception EX)
            {

                throw;
            }

            return user;
        }

        public async Task<int> UpdateRefreshTokenExpired(UpdateRefreshTokenExpired_RequestData requestData)
        {
            var result = 0;
            try
            {
                var user = _eShopDbContext.user.Where(s => s.UserID == requestData.UserID).FirstOrDefault();
                if (user != null && user.UserID > 0)
                {
                    user.refeshtoken = requestData.refeshtoken;
                    user.RefreshTokenExpired = requestData.RefreshTokenExpired;

                    _eShopDbContext.Update(user);
                }

                return result = 1;
            }
            catch (Exception ex)
            {

                return result = -99;
            }
        }

        public async Task<UserFunction> UserFunctionGet(int UserId, int FunctionId)
        {
            return _eShopDbContext.userfunction.Where(s => s.UserId == UserId && s.FunctionID == FunctionId).FirstOrDefault();
        }
    }
}
