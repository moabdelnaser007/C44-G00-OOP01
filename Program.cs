using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP01
{
    internal class Program
    {

        #region 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
        enum WeekDays
        {
            Sunday,     
            Monday,     
            Tuesday,    
            Wednesday,  
            Thursday,   
            Friday,     
            Saturday
        }
        #endregion

        #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        //struct person
        //{
        //    public string name;
        //    public int age;
        //}
        #endregion

        #region 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        enum season
        {
            spring,
            summer,
            autumn,
            winter
        }
        #endregion

        #region 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        enum colors
        {
            red,
            green,
            blue
        }
        #endregion

        #region 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        struct Person
        {
            public string Name;
            public int Age;
        }
        #endregion

        static void Main(string[] args)
        {
            #region 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
            Console.WriteLine("Days of the Week:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //person[] people = new person[3];

            //people[0].name = "ali";
            //people[0].age = 15;

            //people[1].name = "omar";
            //people[1].age = 30;

            //people[2].name = "waleed";
            //people[2].age = 21;

            //Console.WriteLine("people list:");
            //foreach (person person in people) 
            //{
            //    Console.WriteLine($"{person.name} is {person.age} years old ");
            //}
            #endregion

            #region 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();

            bool isValid = Enum.TryParse(input, true, out season selectedSeason);

            if (isValid)
            {
                string months = selectedSeason switch
                {
                    season.spring => "March to May",
                    season.summer => "June to August",
                    season.autumn => "September to November",
                    season.winter => "December to February",
                    _ => "Unknown season"
                };

                Console.WriteLine($"Season: {selectedSeason} ➡️ Months: {months}");
            }
            else
            {
                Console.WriteLine("Invalid season name. Please enter Spring, Summer, Autumn, or Winter.");
            }
            #endregion

            #region 5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            Console.WriteLine("enter color");
            string input01 = Console.ReadLine();

            bool isValid01 = Enum.TryParse(input01, true, out colors selectedColor);

            if (isValid)
            {
                Console.WriteLine($"{selectedColor} is a primary color.");
            }
            else
            {
                Console.WriteLine("The entered color is not a primary color.");
            }
            #endregion

            #region 7. Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            Person[] people = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter details for person #{i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Invalid input. Please enter a valid number for age: ");
                }

                Person person = new Person();
                person.Name = name;
                person.Age = age;
                people[i] = person;

                //people[i].Name = name;
                //people[i].Age = age;
            }

            Person oldest = people[0];
            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }

            Console.WriteLine($"\nThe oldest person is: {oldest.Name}, Age: {oldest.Age}");
            #endregion

        }
    }
}