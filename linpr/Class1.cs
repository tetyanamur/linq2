using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercise
{
    internal class Resident
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int YearsOfLiving { get; set; }

        public Resident(string firstName, string lastName, int age, int yearsOfExperience)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            YearsOfLiving = yearsOfExperience;
        }

        public Resident()
        {

        }
    }
}