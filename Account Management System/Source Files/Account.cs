using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMidAssignment
{
    internal struct MyDate
    {
        private byte day;
        private string month;
        private ushort year;
        internal MyDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                this.day = 1;
                this.month = "January";
                this.year = 1980;
            }
        }
        internal void ShowDate()
        {
            Console.WriteLine("Account Opening Date: {0}/{1}/{2}", this.day, this.month, this.year);
        }
    }

    internal struct MyAddress
    {
        private byte apartmentNo; 
        private byte roadNo;
        private string district;
        private string country;

        internal MyAddress(byte apartmentNo, byte roadNo, string district, string country)
        {
            this.apartmentNo = apartmentNo;
            this.roadNo = roadNo;
            this.district = district;
            this.country = country;
        }

        internal void ShowAddress()
        {
            Console.WriteLine("Address Info: \nApartment No: {0}; Road No: {1}; District: {2}; Country: {3}", this.apartmentNo, this.roadNo, this.district, this.country);
        }
    }
    internal class Account
    {
        private string name;
        private string id;
        private MyDate openingDate;
        private MyAddress address;
        private double balance;        
        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = value;
            }
        }
        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        internal MyDate OpeningDate
        {
            get { return this.openingDate; }
            set { this.openingDate = value; }
        }
        internal MyAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        internal double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        internal Account(string id, string name, MyDate openingDate, MyAddress address, double balance)
        {
            this.Id = id;
            this.Name = name;
            this.OpeningDate = openingDate;
            this.Address = address;
            this.Balance = balance;
        }

        internal virtual void Deposit(double amount)
        {
            this.Balance += amount;
            Console.WriteLine("{0} taka has been depositted successfully.", amount);
        }

        internal virtual void Withdraw(double amount)
        {
            this.Balance -= amount;
            Console.WriteLine("{0} taka has been withdrawn successfully.", amount);
        }

        internal void ShowInfo()
        {
            Console.WriteLine("Account Information: ");
            Console.WriteLine("Account ID: {0}", this.Id);
            Console.WriteLine("Account Name: {0}", this.Name);
            this.OpeningDate.ShowDate();
            this.Address.ShowAddress();
            Console.WriteLine("Account Balance: {0}", this.Balance);
        }
    }
}
