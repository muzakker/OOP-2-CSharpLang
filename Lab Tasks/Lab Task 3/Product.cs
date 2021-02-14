using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask3
{
    struct ProductionDate
    {
        internal byte day;
        internal string month;
        internal ushort year;

        internal ProductionDate(byte day, string month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        internal void ShowDate()
        {
            Console.WriteLine("Manufacture Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }
    internal class Product
    {
        protected ushort id;
        protected byte quantity;
        protected double price;
        protected ProductionDate dateOfProduction;
        protected string manufacturerName;

        internal Product(ushort id, byte quantity, double price, ProductionDate dateOfProduction, string manufacturerName)
        {
            this.Id = id;
            this.Quantity = quantity;
            this.Price = price;
            this.DateOfProduction = dateOfProduction;
            this.ManufacturerName = manufacturerName;
        }

        internal ushort Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        internal byte Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
        internal double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        internal ProductionDate DateOfProduction
        {
            get { return this.dateOfProduction; }
            set { this.dateOfProduction = value; }
        }
        internal string ManufacturerName
        {
            get { return this.manufacturerName; }
            set { this.manufacturerName = value; }
        }

        internal virtual double extraCharge(double price)
        {
            return -1;
        }
        internal virtual void ShowInfo()
        {
            Console.WriteLine("Product Information: ");
            Console.WriteLine("Product ID: {0}", this.Id);
            Console.WriteLine("Product Quantity: {0}", this.Quantity);
            Console.WriteLine("Production Date: {0}", this.dateOfProduction);
            Console.WriteLine("Product Manufacturer Name: {0}", this.ManufacturerName);
            Console.WriteLine("Product Price: {0}", this.Price);
        }
    }
}
