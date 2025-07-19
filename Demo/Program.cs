using Demo.UserDefinedDataTypes;
using Demo.UserDefinedDataTypes.Enums;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region video 4 (Enum Example 01)
            Person person = new Person();
            person.Id = 1;
            person.Name = "Ahmed";
            person.gender = Gender.Male;

            Console.WriteLine(person.gender);

            Grade grade = Grade.A;
            if (grade == Grade.A)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == Grade.B)
            {
                Console.WriteLine("Good");
            }
            else if (grade == Grade.C)
            {
                Console.WriteLine("Average");
            }
            else
            {
                Console.WriteLine("Poor");
            }

            grade = (Grade)5;
            Console.WriteLine(grade);
            #endregion

            #region video 5 (Enum Example 02)
            Student student = new Student();
            Console.WriteLine("Please Enter Student Data: ");
            Console.Write("Id: ");
            bool isParsed;
            do
            {
                isParsed = int.TryParse(Console.ReadLine(), out int id);
            } while (!isParsed);

            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.WriteLine("Gender: ");
            object gender;
            do
            {
                isParsed = Enum.TryParse(typeof(Gender), Console.ReadLine(), out gender);
            } while (!isParsed);

            student.gender = (Gender) gender;
            #endregion
        }
    }
}
