using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    struct EmployeeAddress
    {
        private byte houseNo;
        private string streetName;
        private string upazilaName;
        public EmployeeAddress(byte houseNo, string streetName, string upazilaName)
        {
            this.houseNo = houseNo;
            this.streetName = streetName;
            this.upazilaName = upazilaName;
        }

        public void ShowAddress()
        {
            Console.WriteLine("Employee Address: House: {0}; Street: {1}; Upazila: {2}", this.houseNo, this.streetName, this.upazilaName);
        }
    }
    class Employee
    {
        private ushort id;
        private string name;
        private double monthlySalary;
        private string joiningDate;
        EmployeeAddress employeeAddress;

        internal Employee()
        {
            //default constructor
        }

        internal Employee(ushort id, string name, double monthlySalary, string joiningDate, EmployeeAddress employeeAddress)
        {
            this.Id = id;
            this.Name = name;
            this.MonthlySalary = monthlySalary;
            this.JoiningDate = joiningDate;
            this.Address = employeeAddress;
        }

        internal ushort Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        internal string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        internal double MonthlySalary
        {
            get
            {
                return this.monthlySalary;
            }
            set
            {
                this.monthlySalary = value;
            }
        }

        internal string JoiningDate
        {
            get
            {
                return this.joiningDate;
            }
            set
            {
                this.joiningDate = value;
            }
        }

        internal EmployeeAddress Address
        {
            get
            {
                return this.employeeAddress;
            }
            set
            {
                this.employeeAddress = value;
            }
        }
        internal double AnnualSalary()
        {
            return (this.monthlySalary * 12);
        }
        public void Expenditure()
        {
            Console.WriteLine("Basic Salary: {0}", this.AnnualSalary() * .50);
            Console.WriteLine("House Rent: {0}", this.AnnualSalary() * .30);
            Console.WriteLine("Medical Allowance: {0}", this.AnnualSalary() * .15);
            Console.WriteLine("Phone Bill: {0}", this.AnnualSalary() * .05);
        }
        internal void ShowEmployeeInfo()
        {
            Console.WriteLine("\nEmployee Information:");
            Console.WriteLine("Employee ID: {0}", this.Id);
            Console.WriteLine("Employee Name: {0}", this.Name);
            Console.WriteLine("Employee Joining Date: {0}", this.JoiningDate);
            this.Address.ShowAddress();
            Console.WriteLine("Employee Monthly Salary: {0}", this.MonthlySalary);
            Console.WriteLine("Employee Annual Salary: {0}", this.AnnualSalary());
            this.Expenditure();

        }
    }
}
