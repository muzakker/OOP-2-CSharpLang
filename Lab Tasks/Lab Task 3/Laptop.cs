using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask3
{
    internal class Laptop : Product
    {
        private ushort memory;
        private double clockSpeed;
        private double batteryLife;

        internal Laptop(ushort id, byte quantity, double price, ProductionDate dateOfProduction, string manufacturerName, ushort memorySize, double clockSpeed, double batteryLife) : base(id, quantity, price, dateOfProduction, manufacturerName)
        {
            this.Memory = memory;
            this.ClockSpeed = clockSpeed;
            this.BatteryLife = batteryLife;
        }
        internal override double extraCharge(double price)
        {
            double vat, surCharge, extraCharge;
            vat = price * 0.10;
            surCharge = price * 0.2;
            extraCharge = (vat + surCharge);
            return extraCharge;
        }

        internal ushort Memory
        {
            get { return this.memory; }
            set { this.memory = value; }
        }
        internal double ClockSpeed
        {
            get { return this.clockSpeed; }
            set { this.clockSpeed = value; }
        }
        internal double BatteryLife
        {
            get { return this.batteryLife; }
            set { this.batteryLife = value; }
        }
        internal void Config()
        {
            Console.WriteLine("Product's Memory: {0}", this.Memory);
            Console.WriteLine("Product's Clock Speed: {0}", this.ClockSpeed);
            Console.WriteLine("Product's Battery Life: {0}", this.BatteryLife);
        }

        internal override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Total Product Price including VAT and SD: {0}", this.extraCharge(Price) + Price);
            this.Config();
        }
    }
}
