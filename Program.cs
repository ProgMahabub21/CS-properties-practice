using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            ManuDate date1 = new ManuDate(10, 07, 2020);
            ManuDate date2 = new ManuDate(10, 05, 2021);

            Product p1 = new Product();
            Product p2 = new Product("p-002", 1250.5f, date2);

            p1.ID = "p-001";
            p1.Date= date1;
            p1.Price=1000f;

            p1.PrintProduct();
            p2.PrintProduct();
        }
    }
}
