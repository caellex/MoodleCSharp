﻿using System;
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
            Console.WriteLine("7. Text Scrambler");
            Console.WriteLine("8. Exit App");

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
                    TextScrambler();
                    break;
                case 8:
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

        static void TextScrambler()
        {
            Console.Clear();
            if (Program.firstLoad == true)
            {
                TextScramblerStartText();
            }
            else Console.Clear();

            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Mirror Word");
            Console.WriteLine("2. Change E's to A's");
            Console.WriteLine("3. Main Menu");

            int userchoice = Int32.Parse(Console.ReadLine());

            switch (userchoice)
            {
                case 1:
                    MirrorWord();
                    break;
                case 2:
                    ChangeLetters();
                    break;
                case 3:
                    Main();
                    break;
                default:
                    Main();
                    break;
            }
        }

        static void TextScramblerStartText()
        {
            firstLoad = false;
            Console.Clear();
            Console.WriteLine("Welcome to the Text Scrambler!");
            Console.WriteLine("Here you will be able to mirror any given word,");
            Console.WriteLine("or you can switch out all E's with A's.\n");
            Console.WriteLine("Press Enter to continue..");
            Console.ReadKey();
        }

        static void MirrorWord()
        {
            Console.Clear();
            Console.Write("What would you like to mirror?: ");
            string mirrorThis = Console.ReadLine();
            string mirroredWord = "";
            for (int i = mirrorThis.Length - 1; i > -1; i--)
            {
                mirroredWord += mirrorThis[i];
            }

            Console.Clear();
            Console.WriteLine($"Your word backwards is: {mirroredWord}\n");
            Console.WriteLine("Press Enter to go back..");
            Console.ReadKey();
            TextScrambler();


        }
        static void ChangeLetters()
        {

            Console.Clear();
            Console.Write("What word would you like to change the letters of?: ");
            string scrambleThis = Console.ReadLine();
            string scrambledWord = "";

            foreach (char letter in scrambleThis)
            {
                if (letter == 'e') scrambledWord += 'a';
                else if (letter == 'E') scrambledWord += 'A';
                else scrambledWord += letter;
            }
            Console.Clear();
            Console.WriteLine($"Your scrambled word is: {scrambledWord}\n");
            Console.WriteLine("Press Enter to go back..");
            Console.ReadKey();
            TextScrambler();


        }

    }


}

