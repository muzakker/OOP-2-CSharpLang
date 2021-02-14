using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask3
{
    internal class CannedFood : Product
    {
        internal CannedFood(ushort id, byte quantity, double price, ProductionDate dateOfProduction, string manufacturerName) : base(id, quantity, price, dateOfProduction, manufacturerName)
        {
           //
        }
        internal void ExpiryDate(ProductionDate DateofProduction)
        {
            Console.WriteLine("Expiration Date of the Product: {0}/{1}/{2}", DateOfProduction.day, DateOfProduction.month, DateOfProduction.year+1);
        }
        internal override double extraCharge(double Price)
        {
            double vat;
            vat = (Price * 0.5);
            return vat;
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Product VAT: {0}", this.extraCharge(Price));
            Console.WriteLine("Total Product Price: {0}", this.extraCharge(Price) + Price);
            this.ExpiryDate(DateOfProduction);
        }
    }
}
