﻿using DataAccess.NetFrameWork;
using DataAccess.NetFrameWork.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{

    internal class Program
    {


        struct Product
        {
            public string ProductName;
            public string ProductDescription;
            public int Price;
            public int Status;

            public Product(string _name, string _description, int _price)
            {
                this.ProductName = _name;
                this.ProductDescription = _description;
                this.Price = _price;
                this.Status = 10;
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
           


            var buscar = new XeKhach("TOYOTA", "LX580", 2023);
            buscar.display_info();


            //var buscar = new XeKhach();
            //buscar.brand = "TOYOTA";
            //buscar.model = "LX570";
            //buscar.year = 2024;
            //buscar.display_info();


            var fatboy = new FatBoy();
            fatboy.Run();
            Console.WriteLine(" fatboy.Run() : " + fatboy.Run());

            var thinboy = new ThinBoy();
            thinboy.Run();

            Console.WriteLine("thinboy.Run() : " + thinboy.Run());


            var func = new GenericFunction<int>();
            int tong_int = func.Tong(10, 19);


            var func2 = new GenericFunction<long>();
            long tong_long = func2.Tong(10, 19);

            var func3 = new GenericFunction<float>();
            float tong_float = func3.Tong(10, 19);

            GenericClass<int> intGenericClass = new GenericClass<int>(86);
            intGenericClass.genericProperty = 2017;
            int intVal = intGenericClass.genericMethod(2019);

            GenericClass<string> strGenericClass = new GenericClass<string>("Welcome to");
            strGenericClass.genericProperty = "Lop ASPNET";
            string strVal = strGenericClass.genericMethod("MR QUAN");

            var arrayList = new ArrayList() { 1, "abc", true };
            arrayList.Reverse();

            var arrayList1 = new ArrayList();
            arrayList1.Add(1);
            arrayList1.Add("string");


            foreach (var item in arrayList)
            {
                Console.WriteLine("item array list : " + item);
            }

            var dictionary = new Dictionary<string, string>();
            dictionary.Add("malop", "NETCORE1");
            dictionary.Add("test", "abc");

            var dictionaryObj = new Dictionary<string, object>();

            var static_Demo = StaticDemo.TongStaticDemo();

            var today = new DateTime(2024, 03, 11);
            Console.WriteLine("today = {0}: ", today.ToString("dd/MM/yyyy"));
            Console.WriteLine("day of week = {0}: ", today.DayOfWeek);

            Console.WriteLine("Next day = {0}: ", today.AddDays(1));
            Console.WriteLine("Previous day = {0}: ", today.AddDays(-1));

            var aInterval = new System.TimeSpan(1, 1, 0, 0);
            Console.WriteLine("Next day TimeSpan = {0}: ", today.Add(aInterval));

            // Thời điểm hiện tại.
            DateTime aDateTime = DateTime.Now;

            // Thời điểm năm 2000
            DateTime y2K = new DateTime(2000, 1, 1);

            // Khoảng thời gian từ năm 2000 tới nay.
            TimeSpan interval = aDateTime.Subtract(y2K);

            Console.WriteLine("Subtract TotalDays = {0}: ", interval.TotalDays);


            string date_string = "11/03/2024";
            var date_from_text = DateTime.ParseExact(date_string, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("date_from_texts = {0}: ", date_from_text.AddDays(2));

            var arr = date_string.Split('/');
            foreach (var item in arr)
            {
                Console.WriteLine("item = {0}: ", item);
            }

            //int inputValue = 10;
            //Console.WriteLine("inputValue ThamTri = {0}: ", inputValue);

            //func.ThamTri(inputValue);

            //Console.WriteLine("inputValue ThamTri = {0}: ", inputValue);

            //int inputValue2 = 20;

            //func.ThamChieu(ref inputValue2);

            //Console.WriteLine("inputValue ThamChieu = {0}: ", inputValue2);

            //int inputValue3;

            //func.ThamChieu_with_Out(out inputValue3);

            //Console.WriteLine("inputValue ThamChieu_with_Out = {0}: ", inputValue3);

            ////  int ketqua2 = func.Tong2();

            //Console.WriteLine("Tong = {0}: ", ketqua);


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

            var product = new Product("ô tô", "xe taxi", 10000000);

            Console.WriteLine("PrductName {0}: ", product.ProductName);

            Console.WriteLine("PriceToString : " + product.PriceToString());

            Console.WriteLine("Enum HocLuckem : " + Diem.DiemKem); // trả về tên thuộc tính

            Console.WriteLine("Enum HocLuckem : " + Convert.ToInt32(Diem.DiemKha)); // giá trị của thuộc tính 

            // Nếu trạng là thành công thì in ra thành công

            if (product.Status == 5)
            {
                Console.WriteLine("PrductName {0}: ");
            }

            if (product.Status == (int)ProductStatus.ThanhCong)
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

            // ---------------------------------------------------------------------
            // Bài số 6 : AbtractClass và Interface
            var productManager = new ProductManager();

            var list = productManager.GetAllProducts();
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine("item : " + item.Name);
                }
            }

            var gui_Value = Guid.NewGuid().ToString();
            Console.WriteLine("gui_Value : " + gui_Value);
            Console.ReadKey();


        }
    }
}
