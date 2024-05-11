using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class HobbyGen
    {
        public static List<string> users = new List<string>
        {
            "Carl",
            "Knut",
            "Nora",
            "Arne",
            "Jens"
        };
        public static void HobbyGeneratorTask()
        {
            string[] hobbies = [
                "is now a treasure hunter. X marks the spot!",
                "is now a professional nap taker. Snore away!",
                "is now a cheese sculptor. Say cheese!",
                "is now a professional cloud watcher. Look up and dream!",
                "is now a ninja warrior. Stealth mode activated!" ];

            if (Program.firstLoad == true)
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
                Program.firstLoad = true;
                Program.Main();
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

            Program.firstLoad = false;
            Console.Write("Press ENTER to continue..");
            Console.ReadKey();
        }
    }
}
