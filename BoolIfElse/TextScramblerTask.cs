using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class TextScramblerTask
    {
        public static void TextScrambler()
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
                    Program.Main();
                    break;
                default:
                    Program.Main();
                    break;
            }
        }

        public static void TextScramblerStartText()
        {
            Program.firstLoad = false;
            Console.Clear();
            Console.WriteLine("Welcome to the Text Scrambler!");
            Console.WriteLine("Here you will be able to mirror any given word,");
            Console.WriteLine("or you can switch out all E's with A's.\n");
            Console.WriteLine("Press Enter to continue..");
            Console.ReadKey();
        }

        public static void MirrorWord()
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

        public static void ChangeLetters()
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
