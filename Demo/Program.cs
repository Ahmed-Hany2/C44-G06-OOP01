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


        }
    }
}
