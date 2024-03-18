using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract int Run();
        public virtual string Jump(int x)
        {
            return Name + "jum " + x + " met";
        }
    }
}
