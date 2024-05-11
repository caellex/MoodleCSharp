using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class Loops
    {
        public static void LoopsTask()
        {

            if (Program.firstLoad == true)
            {
                LoopTaskStartText();
            }
            else Console.Clear();

            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. For-Loop");
            Console.WriteLine("2. ForEach-Loop");
            Console.WriteLine("3. While-Loop");
            Console.WriteLine("4. Main Menu");

            var numberInput = Console.ReadLine();
            switch (numberInput)
            {
                case "1":
                    ForLoop();
                    break;
                case "2":
                    ForEachLoop();
                    break;
                case "3":
                    WhileLoop();
                    break;
                case "4":
                    Program.Main();
                    break;
                default:
                    Environment.Exit(69);
                    break;
            }
        }

        static void LoopTaskStartText()
        {
            Program.firstLoad = false;
            Console.Clear();
            Console.WriteLine("Welcome to the Loop tester!");
            Console.WriteLine("This is not so interesting, as it's more aimed towards the code.");
            Console.WriteLine("You'll see some output strings, thats about it.\n");


            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
        }


        static void ForLoop()
        {
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. This is a for loop printing this text 5 times.");
            }
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
            LoopsTask();
        }
        static void ForEachLoop()
        {
            string forEachString = "Honorificabilitudinitatibus";
            Console.Clear();
            Console.WriteLine("This loop goes through a string using ForEach, just like with an array in JS.");
            foreach (char letter in forEachString)
            {
                Console.WriteLine($" {letter}");
            }
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
            LoopsTask();

        }
        static void WhileLoop()
        {
            Console.Clear();
            Console.WriteLine("This while loop prints out rounds until it hits round 10.");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"Round {i}");
                i++;
            }
            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
            LoopsTask();

        }
    }
}
