using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class GenericFunction<T>
    {
        public GenericFunction()
        {

        }
        public T Tong(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;

        }
    }
}
