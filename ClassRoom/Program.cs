using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 3
            ClassRoom classRoom = new ClassRoom()
            {
                ClassName = "Q3",
                SemesterStart = new DateTime(2019, 08, 26)
            };

            classRoom.ClassList.Add(new Student("Niko", 12, 21));
            classRoom.ClassList.Add(new Student("Adriana", 09, 08));
            classRoom.ClassList.Add(new Student("Nohely", 07, 14));
            classRoom.ClassList.Add(new Student("Vladimir", 03, 10));
            classRoom.ClassList.Add(new Student("Nathan", 08, 20));

            // Task 4
            Console.WriteLine($"Class name: {classRoom.ClassName}, " +
                              $"Semester beginn: {classRoom.SemesterStart.ToShortDateString()} \n");
            Console.WriteLine("Enrolled students:");
            foreach (var student in classRoom.ClassList)
            {
                Console.WriteLine($"Student Name: {student.Name} \n\t Birthday: {student.BirthDay}.{student.BirthMonth}.");
            }

            Console.WriteLine();
            BirthsPerSeason(classRoom.ClassList);
            
            Console.WriteLine("\nPress any key to close console...");
            Console.ReadKey();
        }

        // Task 6
        private static void BirthsPerSeason(List<Student> students)
        {
            var result = students.GroupBy(s => Season(s.BirthMonth)).Select(g => new
            {
                Season = g.Key,
                Amount = g.Count()
            });

            Console.WriteLine("Birthdays in each season:");
            foreach (var season in result)
            {
                Console.WriteLine($"{season.Season}: {season.Amount} birthdays");
            }
        }

        // Task 5
        private static string Season(int month)
        {
            if (month > 2 && month < 6) return "Spring";
            if (month > 5 && month < 9) return "Summer";
            if (month > 8 && month < 12) return "Autumn";
            return "Winter";
        }
    }
}
