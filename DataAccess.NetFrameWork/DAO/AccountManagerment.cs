using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork.Interface
{
    public class AccountManagerment : IAccount
    {
        public int Account_Insert(Account account)
        {
            var list = GetListAccount();
            list.Add(account);
            return 1;
        }

        public List<Account> GetAccounts()
        {
            return GetListAccount();
        }

        public List<Account> GetListAccount()
        {
            var list = new List<Account>();
            try
            {


                for (int i = 0; i < 10; i++)
                {
                    list.Add(new Account { Id = i, email = "aspnet" + i + "@gmail.com", password = "!@#$" + i });
                }

            }
            catch (Exception)
            {

                throw;
            }

            return list;
        }
    }
}
