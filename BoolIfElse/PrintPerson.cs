using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolIfElse
{
    internal class PrintPerson
    {
        public static Person person1 = new Person { Name = "Carl", Age = 23 }; // When ran, person1 and person2 will reference the same object.
        public static Person person2 = person1; /*
        This would not work if say forexample we had
        int myInt = 1
        int myCopyInt = myInt;

        myCopyInt would simply stay 1, as it's only grabbing its value. Not 100% sure on this topic, but getting there.*/

        public static void printperson()
        {

            Console.Clear();
            Console.WriteLine("1. Show Person");
            Console.WriteLine("2. Age +1");
            Console.WriteLine("3. Change Name");
            Console.WriteLine("4. Show Person 2");
            Console.WriteLine("5. Main Menu");
            int menuChoice = int.Parse(Console.ReadLine());
            switch (menuChoice)
            {
                case 1:
                    showPerson();
                    break;
                case 2:
                    personAgePlus();
                    break;
                case 3:
                    changePersonName();
                    break;
                case 4:
                    showPerson2();
                    break;
                case 5:
                    Program.Main();
                    break;
            }
            {

            }
        }

        static void showPerson()
        {
            Console.Clear();
            Console.WriteLine($"Name: {person1.Name}");
            Console.WriteLine($"Name: {person1.Age}");
            Console.WriteLine("Press Enter to go back..");
            Console.ReadKey();
            printperson();
        }

        static void personAgePlus()
        {
            Console.Clear();
            person1.Age = person1.Age + 1;
            Console.WriteLine($"New age: {person1.Age}\n");
            Console.WriteLine("Press Enter to go back..");
            Console.ReadKey();
            printperson();
        }

        static void changePersonName()
        {
            Console.Clear();
            Console.Write("What would you like to change the user's name to?: ");
            var newName = Console.ReadLine();
            person1.Name = newName;
            Console.WriteLine($"Name successfully changed to: {person1.Name}\n");
            Console.WriteLine("Press Enter to go back..");
            Console.ReadKey();
            printperson();
        }

        static void showPerson2()
        {
            Console.Clear();
            Console.WriteLine($"Name: {person2.Name}");
            Console.WriteLine($"Name: {person2.Age}");
            Console.WriteLine("Press Enter to go back..");
            Console.ReadKey();
            printperson();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
