using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMidAssignment
{
    static class FinancialAccount
    {
        private static Account[] accounts = new Account[10000];
        private static int count = 0;

        internal static void AddAccount(int accountType)
        {
            string name;
            double balance;
            byte day;
            string month;
            ushort year;
            byte apartmentNo;
            byte roadNo;
            string district;
            string country;

            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Date: \n\nEnter Day:");
            day = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Month:");
            month = Console.ReadLine();
            Console.WriteLine("Enter Year: ");
            year = (ushort)Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Address: \nEnter Apartment No:");
            apartmentNo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Road No:");
            roadNo = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter District:");
            district = Console.ReadLine();
            Console.WriteLine("Enter Country:");
            country = Console.ReadLine();
            Console.WriteLine("Enter Balance: ");
            balance = double.Parse(Console.ReadLine());

            if (accountType == 1)
            {
                accounts[count] = new Savings(Convert.ToString(count), name, new MyDate(day, month, year),
                    new MyAddress(apartmentNo, roadNo, district, country), balance);
                count++;
            }
            else if (accountType == 2)
            {
                accounts[count] = new Current(Convert.ToString(count), name, new MyDate(day, month, year),
                    new MyAddress(apartmentNo, roadNo, district, country), balance);
                count++;
            }
            else
            {
                accounts[count] = new Loan(Convert.ToString(count), name, new MyDate(day, month, year),
                    new MyAddress(apartmentNo, roadNo, district, country), balance);
                count++;
            }
            Console.WriteLine("Account has been created successfully.\n");
        }
        internal static int SearchIndividualAccount(string accountID)
        {
            int index = 0;
            bool found = false;
            while (index <= count)
            {
                if (accounts[index] != null)
                {
                    if (accounts[index].Id == accountID)
                    {
                        Console.WriteLine("Account is found.");
                        found = true;
                        return index;
                    }
                }
                index++;
            }
            if (!found)
            {
                Console.WriteLine("Account is not found.");
            }
            return -1;
        }
        internal static void DeleteAccount(string accountID)
        {
            int index = SearchIndividualAccount(accountID);
            string accountName = accounts[index].Name;
            if (index >= 0)
            {
                accounts[index] = null;
                Console.WriteLine("{0}'s Account deleted.\n", accountName);
            }
        }
        internal static void Transfer(string senderId, string receiverId, double amount)
        {
            int senderIndex = SearchIndividualAccount(senderId);
            int receiverIndex = SearchIndividualAccount(receiverId);

            if (accounts[senderIndex].Balance >= amount)
            {
                accounts[senderIndex].Withdraw(amount);
                accounts[receiverIndex].Deposit(amount);
            }
            else
            {
                Console.WriteLine("Transfer cannot be completed due to insufficient balance.");
            }
        }
        internal static void CheckBalance(string accountID)
        {
            int index = SearchIndividualAccount(accountID);
            Console.WriteLine();
            Console.WriteLine("Account Balance is: {0}", accounts[index].Balance);
        }
        internal static void ShowAllAccounts()
        {
            int index = 0;
            while (index <= count)
            {
                if (accounts[index] != null)
                {
                    accounts[index].ShowInfo();
                    Console.WriteLine();
                }
                index++;
            }
        }
        internal static void StartSystem()
        {
           bool flag = true;

            while (flag)
            {
                Console.WriteLine("Please Enter a Choice: ");
                Console.WriteLine("1. Add new Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. Show All Account Information");
                Console.WriteLine("4. Delete Account");
                Console.WriteLine("5. Deposit");
                Console.WriteLine("6. Withdraw");
                Console.WriteLine("7. Transfer");
                Console.WriteLine("8. Check Balance");
                Console.WriteLine("9. Exit System");

                byte choice = (byte)Convert.ToInt16(Console.ReadLine());
                string accountID;
                int index;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add new Account:");
                        Console.WriteLine("Which type of account do you want to create?");
                        Console.WriteLine("Press 1 for Savings Account");
                        Console.WriteLine("Press 2 for Current Account");
                        Console.WriteLine("Press 3 for Loan Account");
                        int type = Convert.ToInt32(Console.ReadLine());
                        AddAccount(type);
                        break;

                    case 2:
                        Console.WriteLine("Search Account");
                        Console.WriteLine("Enter Account ID: ");
                        accountID = Console.ReadLine();
                        index = SearchIndividualAccount(accountID);
                        Console.WriteLine("Account {0} was found.", accountID);
                        if (index != -1)
                        {
                            accounts[index].ShowInfo();
                        }
                        break;

                    case 3:
                        Console.WriteLine("All  Accounts  Information: ");
                        Console.WriteLine();
                        ShowAllAccounts();
                        break;

                    case 4:
                        Console.WriteLine("Delete Account");
                        Console.WriteLine("Enter Account Id: ");
                        accountID = Console.ReadLine();
                        DeleteAccount(accountID);
                        Console.WriteLine("Account Deleted");
                        break;

                    case 5:
                        Console.WriteLine("Deposite Money");
                        Console.WriteLine("Enter Account Id: ");
                        accountID = Console.ReadLine();
                        Console.WriteLine("Enter how much money you want to deposit: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        index = SearchIndividualAccount(accountID);
                        accounts[index].Deposit(depositAmount);
                        CheckBalance(accountID);
                        accounts[index].ShowInfo();
                        break;

                    case 6:
                        Console.WriteLine("Withdraw Money");
                        Console.WriteLine("Enter Account Id: ");
                        accountID = Console.ReadLine();
                        Console.WriteLine("Enter how much money you want to withdraw: ");
                        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                        index = SearchIndividualAccount(accountID);
                        accounts[index].Withdraw(withdrawalAmount);
                        CheckBalance(accountID);
                        Console.WriteLine();
                        Console.WriteLine();
                        accounts[index].ShowInfo();
                        break;

                    case 7:
                        Console.WriteLine("Transfer Money");
                        Console.WriteLine("Enter Sender Account Id: ");
                        string sendersId = Console.ReadLine();
                        Console.WriteLine("Enter Receiver Account Id: ");
                        string receiversId = Console.ReadLine();
                        Console.WriteLine("Enter amount: ");
                        double transferAmount = Convert.ToDouble(Console.ReadLine());
                        Transfer(sendersId, receiversId, transferAmount);
                        index = SearchIndividualAccount(sendersId);
                        CheckBalance(sendersId);
                        accounts[index].ShowInfo();
                        index = SearchIndividualAccount(receiversId);
                        CheckBalance(receiversId);
                        accounts[index].ShowInfo();
                        break;

                    case 8:
                        Console.WriteLine("Account Balance Check");
                        Console.WriteLine("Enter Account Id: ");
                        accountID = Console.ReadLine();
                        CheckBalance(accountID);
                        break;

                    case 9:
                        Console.WriteLine("Exiting System.");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Please Choose A Valid Option");
                        break;
                }
            }
        }

    }
}
