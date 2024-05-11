using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class CrocGame
    {
        public static void CrocodileGame()
        {
            Random rand = new Random();
            var RandomNum = rand.Next(1, 11);
            var RandomNum2 = rand.Next(1, 11);

            if (Program.firstLoad == true)
            {
                CrocodileGameStartText();
            }
            else Console.Clear();

            Console.Clear();
            Console.WriteLine($"{RandomNum} _ {RandomNum2}                                                               Points: {Program.points}");
            char userInput = Console.ReadKey().KeyChar;

            if (RandomNum > RandomNum2)
            {
                if (userInput == '>')
                {
                    Console.WriteLine("Correct!");
                    Program.points++;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '<')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    Program.points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '=')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    Program.points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
            }
            if (RandomNum < RandomNum2)
            {
                if (userInput == '<')
                {
                    Console.WriteLine("Correct!");
                    Program.points++;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '>')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    Program.points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '=')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    Program.points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
            }
            if (RandomNum == RandomNum2)
            {
                if (userInput == '=')
                {
                    Console.WriteLine("Correct!");
                    Program.points++;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '<')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    Program.points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '>')
                {
                    Console.WriteLine("\nWrong answer! Point deducted.");
                    Program.points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }


            }
            if (userInput != '<' || userInput != '>' || userInput != '=')
            {
                Console.Clear();
                Console.WriteLine("You are about to exit to the Main Menu, are you sure? All progress will be lost. \n");
                Console.WriteLine("Y or N?");
                char exitInput = Console.ReadKey().KeyChar;
                if (exitInput == 'y' || exitInput == 'Y') Program.Main();
                else if (exitInput == 'n' || exitInput == 'N') CrocodileGame();
            }

        }

        static void CrocodileGameStartText()
        {
            Program.firstLoad = false;
            Console.Clear();
            Console.WriteLine("Welcome to the Crocodile Game! \n");
            Console.WriteLine("Your objective is to say if the numbers are greater than, equal to or lesser than eachother.");
            Console.WriteLine("Each correct answer gives you one point, a wrong answer will subtract a point.");
            Console.WriteLine("If you want to exit at any time, type anything other than '<' '=' '>', and the game will automatically exit.");
            Console.WriteLine("Good luck!");

            Console.WriteLine("\nPress Enter to start..");
            Console.ReadKey();
        }
    }
}
