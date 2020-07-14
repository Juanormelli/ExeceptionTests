using Bank.Entities;
using Bank.Entities.Exceptions;
using System;
using System.Globalization;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Number of account: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("WithDraw Limit : ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, name, balance, withdrawLimit);
                Console.WriteLine();

                Console.WriteLine(account);

                Console.WriteLine();

                Console.Write("Make withdrawal or deposit: (w/d) ");
                char Option = char.Parse(Console.ReadLine().ToLower());
                if (Option == 'd')
                {
                    Console.Write("Enter With Amount for deposit: ");
                    double deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.Deposit(deposit);
                }
                else
                {
                    Console.Write("Enter Withdraw Amount: ");
                    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    account.WithDraw(withdraw);
                }

                Console.WriteLine();

                Console.WriteLine("New "+account);
            }
            catch (AppException e)
            {
                Console.WriteLine("Error: "+ e.Message);
            }
        }
    }
}
