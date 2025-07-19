using Assignment.Enums;
using System.ComponentModel;
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

        }
    }
}
