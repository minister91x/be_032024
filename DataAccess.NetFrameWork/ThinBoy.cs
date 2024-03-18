using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork
{
    public class ThinBoy : Person
    {
        // Chỉ chuột vào chữ ThinBoy nhần ALT+ ENTER
        public override int Run()
        {
            return 15;
        }
    }
}
