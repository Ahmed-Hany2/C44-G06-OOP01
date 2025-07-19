using Assignment.Enums;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create an enum called "WeekDays" with the days of the week
            //(Monday to Sunday) as its members.Then, write a C# program that
            //    prints out all the days of the week using this enum.

            string[] weekDays = Enum.GetNames(typeof(WeekDays));
            Console.WriteLine("Days of the week:");
            foreach (string day in weekDays)
            {
                Console.WriteLine(day);
            }


            //2.Create an enum called "Season" with the four seasons(Spring,
            //Summer, Autumn, Winter) as its members.Write a C# program that
            //takes a season name as input from the user and displays the
            //corresponding month range for that season. Note range for seasons (
            //spring march to may , summer june to august, autumn September to
            //November, winter December to February)


            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string userInput = Console.ReadLine();

            bool isValid = Enum.TryParse(userInput, true, out Season enteredSeason);

            if (isValid)
                switch (enteredSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            
            else
               Console.WriteLine("Invalid season");


            //4 - Assign the following Permissions(Read, write, Delete, Execute) in a
            //form of Enum.
            //● Create Variable from previous Enum to Add multible
            //Permission
            Permissions permissions = Permissions.Read | Permissions.Write | Permissions.Execute | Permissions.Delete;
            Console.WriteLine("Permissions are: " + permissions);
            if ((permissions & Permissions.Write) == Permissions.Write)
                Console.WriteLine("User has Write permissions");


            //5.Create an enum called "Colors" with the basic colors(Red, Green, Blue)
            //as its members.Write a C# program that takes a color name as input from
            //the user and displays a message indicating whether the input color is a
            //primary color or not.
            Console.Write("Enter a color : ");
            string input = Console.ReadLine();

            bool isAllowed = Enum.TryParse(input, true, out Colors color);

            if (isAllowed)
                Console.WriteLine($"{color} is a primary color.");
            else
                Console.WriteLine($"{input} is not a primary color.");

        }
    }
}
