using System;
using System.Security.Cryptography.X509Certificates;

namespace BoolIfElse
{
    internal class Program
    {
        public static bool firstLoad = true;
        public static int points = 0;
        public static void  Main()
        {
            firstLoad = true;
            points = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.WriteLine("Welcome! Time to look at some tasks.\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Equal / Unequal");
            Console.WriteLine("2. Hobby Generator");
            Console.WriteLine("3. Day of the week number outputter");
            Console.WriteLine("4. Loops");
            Console.WriteLine("5. Crocodile Game");
            Console.WriteLine("6. Print Person");
            Console.WriteLine("7. Exit App");

            int menuChoice = int.Parse(Console.ReadLine());
            CheckInput(menuChoice);
        }

        static void CheckInput(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    IfElse.IfElseTask();
                    break;
                case 2:
                    HobbyGen.HobbyGeneratorTask();
                    break;
                case 3:
                    WeekDays.DayofTheWeekTask();
                    break;
                case 4:
                    Loops.LoopsTask();
                    break;
                case 5:
                    CrocGame.CrocodileGame();
                    break;
                case 6:
                    PrintPerson.printperson();
                    break;
                case 7:
                    Environment.Exit(69);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Im not entirely sure if you're stupid or just a bot.. Try again.");
                    Console.ReadKey();
                    Main();
                    break;
            }

        }


    }


}

