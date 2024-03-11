using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class InvalidStudentNameException : Exception
    {
        const string erroMessage = "Dữ liệu quá dài";
        public InvalidStudentNameException() : base(erroMessage)
        {
        }

        public InvalidStudentNameException(int number)
        : base(String.Format("Invalid Number: {0}", number))
        {

        }

    }
}
