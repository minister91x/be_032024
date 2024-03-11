using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class FunctionCSharp
    {
        public int Tong(int a, int b)
        {
            var result = 0;
            try // + tab 2 lần
            {
               // ValidateNumber(a);
                result = a * b;
            }
            catch (InvalidStudentNameException ex)
            {
                var msg = ex.Message;
                var stacktrace = ex.StackTrace;
                throw;
            }

            return result;
        }


        private void ValidateNumber(int a)
        {

            if (a > 2)
            {
                throw new InvalidStudentNameException(a);
            }

        }

        private int Tong2()
        {
            // lênh 1 
            // lênh 2
            // lệnh n
            return 10;
        }

        public void ThamTri(int inputValue)
        {
            inputValue = inputValue * 10;
            Console.WriteLine("Tham tri {0}", inputValue);
        }

        public void ThamChieu(ref int inputValue)
        {
            inputValue = inputValue * 10;
            Console.WriteLine("Tham chieu {0}", inputValue);
        }
        public void ThamChieu_with_Out(out int inputValue)
        {
            inputValue = 110;
            Console.WriteLine("Tham chieu {0}", inputValue);
        }

        public string GetString()
        {
            return "tra_ve_chuoi_nay";
        }

        public static void Performance()
        {
            const int Size = 1000000;
            const int Iterations = 10000;
            double[] data = new double[Size];
            Random rng = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rng.NextDouble();
            }

            double correctSum = data.Sum();

            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < Iterations; i++)
            {
                double sum = 0;
                for (int j = 0; j < data.Length; j++)
                {
                    sum += data[j];
                }
                if (Math.Abs(sum - correctSum) > 0.1)
                {
                    Console.WriteLine("Summation failed");
                    return;
                }
            }
            sw.Stop();
            Console.WriteLine("For loop: {0}", sw.ElapsedMilliseconds);

            sw = Stopwatch.StartNew();
            for (int i = 0; i < Iterations; i++)
            {
                double sum = 0;
                foreach (double d in data)
                {
                    sum += d;
                }
                if (Math.Abs(sum - correctSum) > 0.1)
                {
                    Console.WriteLine("Summation failed");
                    return;
                }
            }
            sw.Stop();
            Console.WriteLine("Foreach loop: {0}", sw.ElapsedMilliseconds);
        }
    }
}
