using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace AssignmentOOP01
{

    internal class Program
    {
        #region 1.	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum
        enum WeekDays : byte
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,Sunday
        }
        static void PrintWeekDays()
        {
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine((WeekDays)i);
            }
        }
        #endregion


        #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        static void Q2()
        {
            Person[] persons = new Person[] { new Person("othman", 20), new Person("hamada", 25), new Person("mohmmed", 30) };
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        #endregion

        #region 3.	Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
        enum Season : byte
        {
            Spring, Summer, Autumn, Winter
        }
        static void MonthRange(Season season)
        {
            switch (season)
            {
                case Season.Spring: Console.WriteLine("march to may"); break;
                case Season.Summer: Console.WriteLine("june to august"); break;
                case Season.Autumn: Console.WriteLine("September to November"); break;
                case Season.Winter: Console.WriteLine("December to February"); break;
                default: Console.WriteLine(season); break;
            }
        }
        #endregion


        #region 5.	Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not
        public enum Colors : byte
        {
            Red, Green, Blue
        }
        static void PrimaryColor(Colors color)
        {
            if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
                Console.WriteLine("is primary color");
            else
                Console.WriteLine("not primary color");
        }
        #endregion

        #region 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# prog 8.	ram that takes details of 3 persons as input from the user and displays the name and age of the oldest person
        static void Q7()
        {
            int valueAge;
            Person[] persons = new Person[3];
            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write("Enter Preson Name: ");
                persons[i].Name = Console.ReadLine();
                do
                {
                    Console.Write($"Enter {persons[i].Name}'s age: ");
                } while (!int.TryParse(Console.ReadLine(), out valueAge));
                persons[i].Age = valueAge;
            }
            if (persons[0].Age > persons[2].Age && persons[0].Age > persons[1].Age)
            {
                Console.WriteLine(persons[0].ToString());
            }
            else if (persons[1].Age > persons[2].Age)
            {
                Console.WriteLine(persons[1].ToString());
            }
            else
            {
                Console.WriteLine(persons[2].ToString());
            }


        } 
        #endregion

        static void Main(string[] args)
        {
            //PrintWeekDays();

            //Q2();

            //MonthRange(Season.Spring);

            //PrimaryColor(Colors.Green);
            #region 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            Point p1 = new Point(12, 11);
            Point p2 = new Point(5, 6);
            int dx = p1.x - p2.x;
            int dy = p1.y - p2.y;
            double result = Math.Sqrt(dx * dx + dy * dy);
            #endregion


            Q7();


        }
    }
}
