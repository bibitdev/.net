using System;

namespace P1_22SA11A021
{
    class Praktikum
    {
        static void Main(String[]args)
        {
            int amount = 3000, deposit, withdraw;
            int choise, pin = 0;
            Console.WriteLine("Enter Your 6 Digit Pin");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Welcome To Developer Bank ATM Service! \n");
                Console.WriteLine("1. Current Balance \n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("------------------------");
                Console.WriteLine("Enter Your Choise: ");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("\n Your Current Balance is Rp: {0}", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n Enter The Withdraw amount: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 !=0)
                        {
                            Console.WriteLine("\n Please Enter the Amoubt in Above 500");
                        }
                        else if (withdraw > (amount - 10000))
                        {
                            Console.WriteLine("\n Sorry Insufficent Balance");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n \n Please Collect Your Cash!");
                            Console.WriteLine("\n Current Balance is Rp:{0}", amount);
                        }
                            break;
                    case 3:
                        Console.WriteLine("\n Enter The Deposit Amount!");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Your Amount Has Been Deposited Successfully!");
                        Console.WriteLine("Your Total Balance is Rp:{0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank You!");
                        break;

                }
                Console.WriteLine("\n \n Thanks for Using Developer Bank ATM Service!");

            }
        }
    }
}