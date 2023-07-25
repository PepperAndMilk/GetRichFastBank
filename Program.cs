using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRichFastBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
        falseusername:
            Console.WriteLine("*******Harsha Bank*******");
            Console.WriteLine("---Get rich fast with us---");
            Console.WriteLine("::Login Page::");


            //declare variable to store username and pass
            string userName = null, password = null;

            
            //read username from user's keyboard
            Console.Write("Username: ");
            userName = Console.ReadLine();

            //read pass from keyboard only if username is entered
            if (userName != "" )
            {
                //read password from user's keyboard
                Console.Write("Password: ");
                password = Console.ReadLine();
            }
            
            //check username and pass
            if (userName == "manager" && password == "123")
            {
                    //declare variable to store user's choice
                    int mainMenuChoice = -1;
                do
                {

                    System.Console.WriteLine("\n::Main Menu::");
                    Console.WriteLine("1. Customer");
                    Console.WriteLine("2. Account");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds Transfer Statement");
                    Console.WriteLine("5. Account Statement");
                    Console.WriteLine("0. Exit");

                    Console.WriteLine("Enter choice");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    //switch case to indentify menu choice
                    switch (mainMenuChoice)
                    {
                        case 0: break; 
                        case 1: break;
                        case 2: break;
                        case 3: break;
                        case 4: break;
                        case 5: break;
                    }
                }while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Invalid username or password, please try again");
                Console.ReadKey();
                Console.Clear();
                goto falseusername;
            }
            Console.WriteLine("Thank you for visiting!");
            Console.ReadKey();

        }
    }
}
