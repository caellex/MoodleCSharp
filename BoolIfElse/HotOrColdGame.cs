using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class HotOrColdGame
    {
        public static void HotOrCold()
        {
            bool CorrectGuess = false;

            Console.Clear();
            Console.WriteLine("Welcome to Hot or Cold!");
            Console.WriteLine("A random number between 0 - 100 will be selected,");
            Console.WriteLine("your job is to guess the number. Good luck!\n");

            Console.WriteLine("Press Enter to continue..");
            Console.ReadKey();

            HotOrColdGameLoop();
        }
        public static void HotOrColdGameLoop()
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 100);

            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("A number between 0 - 100 has been selected. Get to guessing!");
                Console.Write("I think the number is: ");
                int userGuess = Int32.Parse(Console.ReadLine());



                if (userGuess > randomNum)
                {
                    Console.Clear();
                    Console.WriteLine("It's lower..\n");

                    Console.WriteLine("Press Enter to try again..");
                    Console.ReadLine();

                }
                else if (userGuess < randomNum)
                {
                    Console.Clear();
                    Console.WriteLine("It's higher..\n");

                    Console.WriteLine("Press Enter to try again..");
                    Console.ReadLine();
                }
                else if (userGuess == randomNum)
                {
                    Console.WriteLine("Congratulations! You are correct.");

                    Console.WriteLine("Press Enter to try again or press X to exit to Main menu.");
                    char userNav = Console.ReadKey().KeyChar;
                    if (userNav == 'x') Program.Main();
                    else HotOrCold();
                }
            }
        }
    }
}
