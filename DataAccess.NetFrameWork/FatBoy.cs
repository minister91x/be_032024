using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork
{
    public class FatBoy : Person
    {
        public override int Run()
        {
            return 5;
        }

        //public override string Jump(int x)
        //{
        //     return Name + "jum "+ "20 met";
        //}
    }
}