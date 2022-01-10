using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W02_01_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hello World!

            HelloWorld();

            Console.WriteLine("Wat is uw naam?");
            string name = Console.ReadLine();

            SayHi(name);

            int age = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = CalculateYearOfBirth(age);

            Console.WriteLine($"U bent geboren in {yearOfBirth}. Geweldig!");

            #endregion

            #region Student

            Student student = new Student();

            student.StudentMethod1();
            // This is private so we cannot use it here: student.StudentMethod2

            Console.Write("Naam van de student: ");
            string nameStudent = Console.ReadLine();

            Console.Write("Achternaam van de student: ");
            string surname = Console.ReadLine();

            Console.Write("Eerste examencijfer van de student: ");
            int grade1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tweede examencijfer van de student: ");
            int grade2 = Convert.ToInt32(Console.ReadLine());

            student.AverageGrade(nameStudent, surname, grade1, grade2);

            #endregion

            #region Math - Calculator

            Math math = new Math();

        ChooseAgain:
            math.Menu();

            Console.Write("\nOperatie nummer: ");
            int opr = Convert.ToInt32(Console.ReadLine());

            decimal result = 0, num1, num2;
            string eerste = "\nEerste nummer: ";
            string tweede = "Tweede nummer: ";

            switch (opr)
            {
                case 1:
                    Console.Write(eerste);
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write(tweede);
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    result = math.Addition(num1, num2);
                    break;

                case 2:
                    Console.Write(eerste);
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write(tweede);
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    result = math.Subtraction(num1, num2);
                    break;

                case 3:
                    Console.Write(eerste);
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write(tweede);
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    result = math.Multiplication(num1, num2);
                    break;

                case 4:
                    Console.Write(eerste);
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.Write(tweede);
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    result = math.Division(num1, num2);
                    break;

                case 5:
                    Console.Write("Nummer voor faculteit: ");
                    int num3 = Convert.ToInt32(Console.ReadLine());

                    result = (decimal)math.Factorial(num3);
                    break;

                default:
                    Console.WriteLine("VERKEERDE KEUZE!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto ChooseAgain;
            }

            Console.WriteLine($"Het resultaat is {result}.");

            #endregion

            Console.ReadLine();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hallo Wereld!");
        }

        static void SayHi(string name)
        {
            Console.WriteLine($"Hoi {name}! Hoe oud bent u?");
        }

        static int CalculateYearOfBirth(int age)
        {
            int thisYear = DateTime.Now.Year;
            int yearOfBirth = thisYear - age;

            return yearOfBirth;
        }

        /*
         * static - 
         * public - 
         * private -
         * protected - 
         * internal -
         * internal protected -
         */
    }
}