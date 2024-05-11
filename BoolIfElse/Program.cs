using System;
using System.Security.Cryptography.X509Certificates;

namespace BoolIfElse
{
    internal class Program
    {
        static void Main()
        {
            firstLoad = true;
            points = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome! Time to look at some tasks.\n");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Equal / Unequal");
            Console.WriteLine("2. Hobby Generator");
            Console.WriteLine("3. Day of the week number outputter");
            Console.WriteLine("4. Loops");
            Console.WriteLine("5. Crocodile Game");
            Console.WriteLine("6. Exit App");
            int menuChoice = int.Parse(Console.ReadLine());
            CheckInput(menuChoice);
        }

        static void CheckInput(int userChoice)
        {
            switch (userChoice)
            {
                case 1:
                    IfElseTask();
                    break;
                case 2:
                    HobbyGeneratorTask();
                    break;
                case 3:
                    DayofTheWeekTask();
                    break;
                case 4:
                    LoopsTask();
                    break;
                case 5:
                    CrocodileGame();
                    break;
                case 6:
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

        static void IfElseTask()
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
                    Main();
                    break;
                default:
                    Main();
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
                if (userInput == mainMenu) Main();
                IfEqual1();
            }
            else
            {
                Console.WriteLine("Not equal! Try again.");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Main();
                IfEqual1();
            }

            Main();
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
                if (userInput == mainMenu) Main();
                IfEqual2();
            }
            else
            {
                Console.WriteLine("Numbers are not equal!");
                Console.Write($"Numbers multiplied with eachother are: {userNum1 + userNum2}\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Main();
                IfEqual2();
            }

            Main();
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
                if (userInput == mainMenu) Main();
                IfEqual3();
            }
            else
            {
                Console.WriteLine("False! None of the numbers, or the sum of both are equal to 30.\n");
                Console.Write("Press Enter to try again or X to exit to main menu.");
                char userInput = Console.ReadKey().KeyChar;
                char mainMenu = 'x';
                if (userInput == mainMenu) Main();
                IfEqual3();
            }

            Main();
        }

        public static List<string> users = new List<string>
        {
            "Carl",
            "Knut",
            "Nora",
            "Arne",
            "Jens"
        };
        public static bool firstLoad = true;
        static void HobbyGeneratorTask()
        {


            string[] hobbies = {
                "is now a treasure hunter. X marks the spot!",
                "is now a professional nap taker. Snore away!",
                "is now a cheese sculptor. Say cheese!",
                "is now a professional cloud watcher. Look up and dream!",
                "is now a ninja warrior. Stealth mode activated!" };

            if (firstLoad == true)
            {
                HobbyStartUpText();
            }
            else Console.Clear();


            var userInput = HobbyGenMenu();

            if (userInput == 1)
            {
                for (int i = 0; i < users.Count; i++)
                {
                    if (!string.IsNullOrEmpty(users[i]))
                    {
                        Console.WriteLine($"{i}. {users[i]}");
                    }

                }
                Console.Write("Press Enter to go back.");
                Console.ReadKey();
                HobbyGeneratorTask();
            }
            else if (userInput == 2)
            {
                Console.WriteLine("What user would you like to change the hobby of? Please use the actual name, not their index.");
                string userToFind = Console.ReadLine();

                string userFound = users.Find(element => element == userToFind);

                Random rand = new Random();
                var randomNumber = rand.Next(0, hobbies.Length);

                if (userFound == "" || userFound == null || userFound == " ")
                {
                    Console.WriteLine("User not found!");
                    Console.WriteLine("Please press ENTER to continue.");
                    Console.ReadKey();
                    HobbyGeneratorTask();
                }
                Console.WriteLine($"{userFound} {hobbies[randomNumber]}");
                Console.WriteLine("Please press ENTER to continue.");
                Console.ReadKey();
                HobbyGeneratorTask();
            }
            else if (userInput == 3)
            {
                Console.Write("What is the name of the user you would like to add?: ");
                var userToAdd = Console.ReadLine();
                users.Add(userToAdd);
                Console.WriteLine($"User added: {userToAdd}");
                Console.ReadKey();
                HobbyGeneratorTask();

            }
            else if (userInput == 4)
            {
                firstLoad = true;
                Main();
            }

        }
        static int HobbyGenMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. User List");
            Console.WriteLine("2. Assign Hobbies");
            Console.WriteLine("3. Add User");
            Console.WriteLine("4. Main Menu");

            int userInput = int.Parse(Console.ReadLine());
            Console.Clear();

            return userInput;
        }
        static void HobbyStartUpText()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the hobby generator!");
            Console.WriteLine("Here you will be able to choose one of the predetermined users, and then the program will assign them a hobby.\n");

            firstLoad = false;
            Console.Write("Press ENTER to continue..");
            Console.ReadKey();
        }

        static void DayofTheWeekTask()
        {
            Console.Clear();
            if (firstLoad == true)
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
            if (userInput == 'x') Main();
            DayofTheWeekTask();
        }

        static void DaysOfTheWeekStartText()
        {
            firstLoad = false;
            Console.WriteLine("Welcome to the Day of the week finder!");
            Console.WriteLine("Simply write in a number from 1-7 and get what day of the week it corresponds to.");
            Console.WriteLine("Simple but it does the job!\n");

            Console.WriteLine("Press ENTER to continue..");
            Console.ReadKey();
        }


        static void LoopsTask()
        {

            if (firstLoad == true)
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
                    Main();
                    break;
                default:
                    Environment.Exit(69);
                    break;
            }
        }

        static void LoopTaskStartText()
        {
            firstLoad = false;
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

        public static int points = 0;
        static void CrocodileGame()
        {
            Random rand = new Random();
            var RandomNum = rand.Next(1, 11);
            var RandomNum2 = rand.Next(1, 11);

            if (firstLoad == true)
            {
                CrocodileGameStartText();
            }
            else Console.Clear();

            Console.Clear();
            Console.WriteLine($"{RandomNum} _ {RandomNum2}                                                               Points: {points}");
            char userInput = Console.ReadKey().KeyChar;

            if (RandomNum > RandomNum2)
            {
                if (userInput == '>')
                {
                    Console.WriteLine("Correct!");
                    points++;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '<')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '=')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    points--;
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
                    points++;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '>')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '=')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    points--;
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
                    points++;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '<')
                {
                    Console.WriteLine("Wrong answer! Point deducted.");
                    points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }
                else if (userInput == '>')
                {
                    Console.WriteLine("\nWrong answer! Point deducted.");
                    points--;
                    Console.WriteLine("Press Enter to continue..");
                    Console.ReadKey();
                    CrocodileGame();
                }


            }
            if(userInput != '<' || userInput != '>' || userInput != '=')
            {
                Console.Clear();
                Console.WriteLine("You are about to exit to the Main Menu, are you sure? All progress will be lost. \n");
                Console.WriteLine("Y or N?");
                char exitInput = Console.ReadKey().KeyChar;
                if (exitInput == 'y' || exitInput == 'Y') Main();
                else if (exitInput == 'n' || exitInput == 'N') CrocodileGame();
            }

        }

        static void CrocodileGameStartText()
        {
            firstLoad = false;
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

