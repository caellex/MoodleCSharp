using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class IfElse
    {
        public static void IfElseTask()
        {
            Console.Clear();
            Console.WriteLine("Welcome to IfElseTask!\n");
            Console.WriteLine("1. Check if equal or unequal");
            Console.WriteLine("2. Check if equal or unequal - Multiply if equal, Add if unequal");
            Console.WriteLine("3. Check if one number or the sum of both are equal to 30");
            Console.WriteLine("4. Main Menu");
            var userInput = Console.ReadLine();



            switch (userInput)
            {
                case "1":
                    IfEqual1();
                    break;
                case "2":
                    IfEqual2();
                    break;
                case "3":
                    IfEqual3();
                    break;
                case "4":
                    Program.Main();
                    break;
                default:
                    Program.Main();
                    break;

            }
        }

        static void IfEqual1()
        {
            Console.Clear();
            Console.WriteLine("This method will check 2 numbers, if they are equal you will get a 'true' return.");
            Console.WriteLine("A simple true or false will be output depending on your input.\n");

            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Please insert your first number: ");
            int userNum1 = int.Parse(Console.ReadLine());



            Console.Write("Please insert your second number: ");
            int userNum2 = int.Parse(Console.ReadLine());

            if (userNum1 == userNum2)
            {
                Console.WriteLine($"The numbers {userNum1} and {userNum2} are equal!\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Program.Main();
                IfEqual1();
            }
            else
            {
                Console.WriteLine("Not equal! Try again.");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Program.Main();
                IfEqual1();
            }

            Program.Main();
        }


        static void IfEqual2()
        {
            Console.Clear();
            Console.WriteLine("This method will check 2 numbers, if they are equal they will be multiplied with eachother.");
            Console.WriteLine("If the numbers are unequal, they will be added together.\n");
            Console.WriteLine("Press enter to continue..");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Please insert your first number: ");
            int userNum1 = int.Parse(Console.ReadLine());
            Console.Write("Please insert your second number: ");
            int userNum2 = int.Parse(Console.ReadLine());

            if (userNum1 == userNum2)
            {
                Console.WriteLine("Numbers are equal!");
                Console.Write($"The sum of these numbers are: {userNum1 * userNum2}\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Program.Main();
                IfEqual2();
            }
            else
            {
                Console.WriteLine("Numbers are not equal!");
                Console.Write($"Numbers multiplied with eachother are: {userNum1 + userNum2}\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Program.Main();
                IfEqual2();
            }

            Program.Main();
        }

        static void IfEqual3()
        {
            Console.Clear();
            Console.WriteLine("This method will check 2 numbers, if the sum of both the numbers, or one of them is equal to 30 it will return true.");
            Console.WriteLine("Otherwise you will get a false.\n");
            Console.WriteLine("Press enter to continue..");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Please insert your first number: ");
            int userNum1 = int.Parse(Console.ReadLine());
            Console.Write("Please insert your second number: ");
            int userNum2 = int.Parse(Console.ReadLine());

            if (userNum1 == 30 || userNum2 == 30 || userNum1 + userNum2 == 30)
            {
                Console.WriteLine("True! One of the numbers, or both summed are equal to 30!\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Program.Main();
                IfEqual3();
            }
            else
            {
                Console.WriteLine("False! None of the numbers, or the sum of both are equal to 30.\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Program.Main();
                IfEqual3();
            }

            Program.Main();
        }
    }
}
