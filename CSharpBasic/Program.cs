using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        struct Product
        {
            public string ProductName;
            public string ProductDescription;
            public int Price;
            public int Status;

            public Product(string _name, string _description, int _price, int _status)
            {
                this.ProductName = _name;
                this.ProductDescription = _description;
                this.Price = _price;
                this.Status = _status;
            }
            public string PriceToString()
            {
                return Price + 15000 + "VND";
            }

        }

        struct Student
        {
            public string StudentName;
            public int HocLuc;

            public Student(string _name, int _hocluc)
            {
                this.StudentName = _name;
                this.HocLuc = _hocluc;
            }
        }

        enum ProductStatus
        {
            KhoiTao = 1,
            ChuagiaoHang = 2,
            DaThanhToan_ChuaGiao = 3,
            ThanhCong = 4,
        }
        enum Diem
        {
            DiemKem = 5,
            DiemTrungBinh = 6,
            DiemKha = 7,
            DiemGioi = 8,
        }

        static void Main(string[] args)
        {
            try
            {
                //  Performance();
                //int myAgeValue = 10;
                //int b = 0;
                ////int c = myAgeValue / b;
                //float abc = 1.0f;
                //var myAgeValue2 = 123;
                //var myAgeValue3 = "abc";


                ////CTRL + K +C 
                ////CTRL+ K + U

                //var total = myAgeValue + myAgeValue2;
                //Console.WriteLine("toltal {0}", total);

                //switch (myAgeValue)
                //{
                //    case 10: break;
                //    case 11: break;
                //    case 12: break;
                //    default: break;
                //}

                //var myValue = myAgeValue == 10 ? 1 : 0;

                //if (myAgeValue == 10)
                //{
                //    myValue = 1;
                //}
                //else
                //{
                //    myValue = 0;
                //}
                //var list = new List<string>();

                //list.Add("Lớp C#");
                //list.Add("MR QUÂN");


                //for (int i = 0; i < list.Count; i++)
                //{
                //    Console.WriteLine("i {0} - {1}", i, list[i]);
                //}

                //foreach (var item in list)
                //{
                //    Console.WriteLine("i {0}", item);
                //}

                var product = new Product("ô tô", "xe taxi", 10000000, 1);

                Console.WriteLine("PrductName {0}: ", product.ProductName);

                Console.WriteLine("PriceToString : " + product.PriceToString());

                Console.WriteLine("Enum HocLuckem : " + Diem.DiemKem); // trả về tên thuộc tính

                Console.WriteLine("Enum HocLuckem : " + Convert.ToInt32(Diem.DiemKha)); // giá trị của thuộc tính 

                // Nếu trạng là thành công thì in ra thành công

                if (product.Status == 5)
                {
                    Console.WriteLine("PrductName {0}: ");
                }

                if (product.Status ==(int)ProductStatus.ThanhCong)
                {
                    Console.WriteLine("PrductName {0}: ");
                }

                int[] bienMang = new int[5];
                int[] myArray = { 1, 3, 5, 19 };

                //for + tab 2 lần 

                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.WriteLine("Index {0} Value {1}", i, myArray[i]);
                }

                Console.WriteLine("PrductName {0}: " + myArray.Max());
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                throw;
            }


        }
    }
}
