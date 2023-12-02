using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3_Elene_Rtveladze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store instances of the Student class
            List<Student> studentList = new List<Student>();



            // Create and add several Students class to the list
            studentList.Add(new Student("Elene", "Rtveladze", new DateTime(2002, 5, 9), 'F', "Caucasus University", "Information Technology", "Programmer", 4));
            studentList.Add(new Student("Mariam", "Vadachkoria", new DateTime(2002, 7, 22), 'F', "Caucasus University", "Information Technology", "Programmer", 4));
            studentList.Add(new Student("Rati", "Kunchulia", new DateTime(1996, 9, 9), 'M', "Free University", "Computer Science", "Programmer", 3));
            studentList.Add(new Student("Giorgi", "Bakuradze", new DateTime(1998, 9, 1), 'M', "Medical University", "Medicine", "Doctor", 1));
            studentList.Add(new Student("Omar", "Jangebashvili", new DateTime(1991, 10, 6), 'M', "Tbilisi State University", "Economy", "Economist", 2));


            // Print information for each student in the list
            foreach (var student in studentList)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine(); // Add a newline for better readability
            }

            // Use LINQ to determine the number of male and female students
            int numberOfGirls = studentList.Count(student => student.Gender == 'F');
            int numberOfBoys = studentList.Count(student => student.Gender == 'M');

            // Print the results
            Console.WriteLine($"Number of female students: {numberOfGirls}");
            Console.WriteLine($"Number of male students: {numberOfBoys}");

            // Use LINQ to determine the top 3 students with the highest average grades
            var top3Students = studentList
.Where(student => student.CalculateAverageGrade() >= 90)
            .OrderByDescending(student => student.CalculateAverageGrade())
            .Take(3);

            // Print the results
            Console.WriteLine("Top 3 Students with Average Grades >= 90:");
            foreach (var student in top3Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname}: {student.CalculateAverageGrade()}");
            }

            // Use LINQ to find the oldest student
            var oldestStudent = studentList
                .OrderBy(student => student.Birthdate)
                .FirstOrDefault();

            // Print the result
            if (oldestStudent != null)
            {
                Console.WriteLine($"Oldest Student: {oldestStudent.Name} {oldestStudent.Surname}");
            }
            else
            {
                Console.WriteLine("No students found.");
            }
            Console.ReadLine();
        }
    }
}
