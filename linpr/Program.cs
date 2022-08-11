using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    internal class Program
    {
        private static int[] numbers = { 5, 3, 18, 14, 12, 60, 77, 81, 94, 0 };

        static void Main(string[] args)
        { var sum = numbers.Sum();
            var average = numbers.Average();
            Console.WriteLine($"sum is {sum} and average is {average}");
            var asc = numbers.OrderBy(num => num);
            foreach (var item in asc)
            {
                Console.WriteLine(item);
            }
            var dsc = numbers.OrderByDescending(num => num);
            foreach (var item in dsc)
            { Console.WriteLine(item); }

            var greatthfive = numbers.Where(num => num > 50);
            foreach (var item in greatthfive)
            { Console.WriteLine(item); }

            Console.WriteLine("----");
            foreach (var num in asc.Take(5))
            { Console.WriteLine(num); }

            Console.WriteLine("---");
            numbers[5] = 24;
            foreach (var item in numbers)
            { Console.WriteLine(item); }

            Console.WriteLine("---");



            var residnets = CreateRes();

            var categorize = residnets.Where(individual => individual.FirstName.ToLower().StartsWith('m'));
            Console.WriteLine("---");
            foreach (var individual in categorize)
            {
                Console.WriteLine(individual.FirstName);
            }
             var agecategory = residnets.Where(r => r.Age < 70).OrderByDescending(r=> r.Age).ThenBy(x => x.FirstName).ThenBy(x => x.LastName);
              foreach (var numb in agecategory)
            {
                Console.WriteLine($"{numb.FullName} Age: {numb.Age}");
            }
            var ageofresliv = residnets.Where(r => r.YearsOfLiving <= 20 && r.Age < 71);
            Console.WriteLine("----");
            Console.WriteLine($"tot yol:{ageofresliv.Sum(x => x.YearsOfLiving)}");
            Console.WriteLine($"tot yol:{ageofresliv.Average(x => x.YearsOfLiving)}");
            #region CreateEmployeesMethod
            static List<Resident> CreateRes()
            {
                List<Resident> residents = new List<Resident>();
                residents.Add(new Resident("Anna", "Jim", 34, 5 ));
                residents.Add(new Resident("Mike", "Collins,", 50, 17));
                residents.Add(new Resident("Mary", "Adams,", 45, 22));
                residents.Add(new Resident("Janet", "Green", 28, 7));
                residents.Add(new Resident("Alex", "Johnson", 70, 18));
                return residents;
            }

        }
    }
}

        #endregion

