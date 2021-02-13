using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAddress addressOne = new EmployeeAddress(253, "Kobi Nazrul Road", "Kotowali");
            Employee employeeOne = new Employee();
            Console.WriteLine("Enter Employee ID:");
            employeeOne.Id = (ushort)Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            employeeOne.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Joining Date:");
            employeeOne.JoiningDate = Console.ReadLine();
            Console.WriteLine("Enter Employee Monthly Salary:");
            employeeOne.MonthlySalary = Convert.ToDouble(Console.ReadLine());
            employeeOne.Address = addressOne;

            employeeOne.ShowEmployeeInfo();

            EmployeeAddress addressTwo = new EmployeeAddress(255, "Ashraf Ali Road", "Double Mooring");
            Employee employeeTwo = new Employee(101, "Muzakker", 75000, "01-Feb-2020", addressTwo);
            employeeTwo.ShowEmployeeInfo();
        }
    }
}
