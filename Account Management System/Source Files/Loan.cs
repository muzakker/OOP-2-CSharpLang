using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMidAssignment
{
    internal class Loan : Account
    {
        internal override string Id
        {
            set
            {
                base.Id = "AL-" + value;
            }
        }
        internal Loan(string id, string name, MyDate openingDate, MyAddress address, double balance) : base(id, name, openingDate, address, balance)
        {
            //constructor
        }

        internal override void Withdraw(double amount)
        {
            if ((base.Balance-50) >= amount)
            {
                base.Withdraw(amount+50);
            }
            else
            {
                Console.WriteLine("Sorry, insufficient balance!!");
            }
        }
    }
}
