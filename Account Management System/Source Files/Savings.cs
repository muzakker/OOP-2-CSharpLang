using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMidAssignment
{
    internal class Savings : Account
    {
        internal override string Id
        {
            set
            {
                base.Id = "AS-" + value;
            }
        }

        internal Savings(string id, string name, MyDate openingDate, MyAddress address, double balance) : base(id, name, openingDate, address, balance)
        {
            //constructor
        }

        internal override void Withdraw(double amount)
        {
            if(base.Balance >= amount && amount <= 2000)
            {
                base.Withdraw(amount);
            }
            else if (amount > 2000)
            {
                Console.WriteLine("Sorry, cannot withdraw more than 2000.");
            }
            else
            {
                Console.WriteLine("Sorry, insufficient balance!!");
            }
        }
    }
}
