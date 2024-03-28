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
            return 1;
        }

        public List<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }
    }
}
