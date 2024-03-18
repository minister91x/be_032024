using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.NetFrameWork
{
    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }

        // ALT + KÉO CHUỘT
        public Car(string _brand, string _model, int _year)
        {
            this.brand = _brand;
            this.model = _model;
            this.year = _year;

        }
        public void display_info()
        {
            Console.Write("Brand {0} model {1} year {2}", brand, model, year); 
        }
    }
}
