using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class WeekDays
    {
        public static void DayofTheWeekTask()
        {
            Console.Clear();
            if (Program.firstLoad == true)
            {
                DaysOfTheWeekStartText();
            }
            else Console.Clear();



            Console.Clear();
            Console.Write("What number would you like to know the corresponding day to? (1-7): ");
            var numberInput = Console.ReadLine();
            if (numberInput == "0") DayofTheWeekTask();

            switch (numberInput)
            {
                case "1":
                    Console.WriteLine($"{numberInput} = Monday");
                    break;
                case "2":
                    Console.WriteLine($"{numberInput} = Tuesday");
                    break;
                case "3":
                    Console.WriteLine($"{numberInput} = Wednesday");
                    break;
                case "4":
                    Console.WriteLine($"{numberInput} = Thursday");
                    break;
                case "5":
                    Console.WriteLine($"{numberInput} = Friday");
                    break;
                case "6":
                    Console.WriteLine($"{numberInput} = Saturday");
                    break;
                case "7":
                    Console.WriteLine($"{numberInput} = Sunday");
                    break;
                default:
                    Console.WriteLine("Instructions unclear, **** stuck in a can.");
                    break;
            }
            Console.Write("Press Enter to try again or X to exit to main menu.");
            char userInput = Console.ReadKey().KeyChar;
            if (userInput == 'x') Program.Main();
            DayofTheWeekTask();
        }

        static void DaysOfTheWeekStartText()
        {
            Program.firstLoad = false;
            Console.WriteLine("Welcome to the Day of the week finder!");
            Console.WriteLine("Simply write in a number from 1-7 and get what day of the week it corresponds to.");
            Console.WriteLine("Simple but it does the job!\n");

            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
        }
    }
}
