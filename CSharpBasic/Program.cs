using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class Program
    {
        public int Tong(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            try
            {
                int myAgeValue = 10;
                int b = 0;
                //int c = myAgeValue / b;
                float abc = 1.0f;
                var myAgeValue2 = 123;
                var myAgeValue3 = "abc";


                //CTRL + K +C 
                //CTRL+ K + U

                var total = myAgeValue + myAgeValue2;
                Console.WriteLine("toltal {0}", total);

                switch (myAgeValue)
                {
                    case 10: break;
                    case 11: break;
                    case 12: break;
                    default: break;
                }

                var myValue = myAgeValue == 10 ? 1 : 0;

                if (myAgeValue == 10)
                {
                    myValue = 1;
                }
                else
                {
                    myValue = 0;
                }
                var list = new List<string>();

                list.Add("Lớp C#");
                list.Add("MR QUÂN");


                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("i {0} - {1}", i, list[i]);
                }

                foreach (var item in list)
                {
                    Console.WriteLine("i {0}", item);
                }


                Console.ReadKey();
            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
