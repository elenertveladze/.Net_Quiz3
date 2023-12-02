using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_Elene_Rtveladze
{
    public class Student
    {
        // Public fields
        public string Name;
        public string Surname;

        // Private fields
        private DateTime birthdate;
        private char gender;
        private string university;
        private string faculty;
        private string specialty;
        private int course;
        private List<int> grades;



        // Constructor to initialize the fields
        public Student(string name, string surname, DateTime birthdate, char gender, string university, string faculty, string specialty,
            int course)
        {
            Name = name;
            Surname = surname;
            this.birthdate = birthdate;
            this.gender = gender;
            this.university = "Sample University";
            this.faculty = "Sample Faculty";
            this.specialty = "Sample Specialty";
            this.course = 1;

            // Generate a list of 10 random numbers between 51 and 100
            grades = GenerateRandomNumbers(10, 51, 100);
        }
        private static Random random = new Random();
        // Method to generate a list of random numbers
        private List<int> GenerateRandomNumbers(int count, int min, int max)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(min, max + 1));
            }

            return numbers;
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        public override string ToString()
        {
            // You can customize this string to include the information you want
            return $"Name: {Name}\nSurname: {Surname}\n" +
                   $"Birthdate: {birthdate}\nGender: {gender}\n" +
                   $"University: {university}\nFaculty: {faculty}\n" +
                   $"Specialty: {specialty}\nCourse: {course}\n" +
                   $"Grades: {string.Join(", ", grades)}";
        }

        public double CalculateAverageGrade()
        {
            // Using LINQ to calculate the average of the random numbers
            double averageGrade = grades.Average();
            return averageGrade;
        }
    }
}
