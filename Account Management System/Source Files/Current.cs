using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMidAssignment
{
    internal class Current : Account
    {
        internal override string Id
        {
            set
            {
                base.Id = "AC-" + value;
            }
        }
        internal Current(string id, string name, MyDate openingDate, MyAddress address, double balance) : base(id, name, openingDate, address, balance)
        {
            //constructor
        }
        internal override void Deposit(double amount)
        {
            if (amount >= 500)
            {
                base.Deposit(amount);
            }
        }
        internal override void Withdraw(double amount)
        {
            if (base.Balance >= amount && amount <= 5000)
            {
                base.Withdraw(amount);
            }
            else if (amount > 5000)
            {
                Console.WriteLine("Sorry, cannot withdraw more than 5000.");
            }
            else
            {
                Console.WriteLine("Sorry, insufficient balance!!");
            }
        }
    }
}
