using System.Globalization;
using System.Security.Cryptography;
using System;

class Program
{

    static string userName = "Mukesh";
    static string password = "123";
    static double balance = 0;



    public static void Main()
    {

        while (true)
        {

            Console.WriteLine("Welcome to XY banking app");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice:  ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Username: ");
                string ipUserName = Console.ReadLine();
                Console.Write("Enter Password: ");
                string ipPasswrod = Console.ReadLine();

                if (ipUserName == userName && ipPasswrod == password)
                {

                    Console.WriteLine($"Welcome {userName}");
                    ShowBankingMenu();

                }
                else
                {
                    Console.WriteLine("Invalid username or password. Press Enter to continue");
                    Console.ReadLine();
                }

            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you. You are logged out.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }

        }

        static void ShowBankingMenu()
        {
            while (true)
            {
                Console.WriteLine(" Banking Menu ");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        Deposit();
                        break;
                    case "3":
                        Withdraw();
                        break;
                    case "4":
                        return; 
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            static void CheckBalance()
            {
                Console.WriteLine($"Current Balance: Rs.{balance}");
                Console.WriteLine("Press Enter to return to menu.");
                Console.ReadLine();
            }
            static void Deposit()
            {
                Console.Write("Enter amount to deposit: ₹");
                if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposit successful. New Balance: Rs. {balance}");
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                Console.WriteLine("Press Enter to return to menu.");
                Console.ReadLine();
            }

            static void Withdraw()
            {
                Console.Write("Enter amount to withdraw: Rs. ");
                if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    if (amount <= balance)
                    {
                        balance -= amount;
                        Console.WriteLine($"Withdrawal successful. New Balance: Rs. {balance}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                Console.WriteLine("Press Enter to return to menu.");
                Console.ReadLine();
            }

        }
    }
    
}