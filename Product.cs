using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInfo
{
    struct ManuDate
    {
        private byte day;
        private byte month;
        private short year;

        public ManuDate(byte day, byte month, short year)
        {

            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void PrintDate()
        {
            Console.WriteLine("Manufracture Date {0}/{1}/{2}", day, month, year);
        }
    }
    class Product
    {
        private string id;
        private float price;
        private ManuDate date;
        public Product()
        {
            //default constructor
        }
        public string ID            //property
        {
            get { return this.id; }     //get method
            set { this.id = value; }  //set method 

        }
        public float Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public ManuDate Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public Product(string id, float price, ManuDate date)
        {
            this.ID = id;
            this.Date=date;
            this.Price = price;
        }
        public void PrintProduct()
        {
            Console.WriteLine("Product Information:-");
            Console.WriteLine("ID {0}", this.ID);
            this.date.PrintDate();
            Console.WriteLine("Price  {0}", this.Price);
        }

    }
}
