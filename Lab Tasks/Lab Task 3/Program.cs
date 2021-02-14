using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductionDate productOneDate = new ProductionDate(12, "Nov", 2020);
            Product productOne = new CannedFood(101, 1, 43.50, productOneDate, "Pran");
            productOne.ShowInfo();

            ProductionDate productTwoDate = new ProductionDate(10, "Nov", 2020);
            Product productTwo = new Laptop(121, 1, 12343, productTwoDate, "Dell", 2, 2.75, 4);
            productTwo.ShowInfo();
        }
    }
}
