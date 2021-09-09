using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

            try
            {
                classRoom.ClassList.Add(new Student("Niko", 12, 21));
                classRoom.ClassList.Add(new Student("Adriana", 09, 08));
                classRoom.ClassList.Add(new Student("Nohely", 07, 14));
                classRoom.ClassList.Add(new Student("Vladimir", 03, 10));
                classRoom.ClassList.Add(new Student("Somebody else", 12, 20));
                classRoom.ClassList.Add(new Student("Nathan", 08, 20));
                classRoom.ClassList.Add(new Student("Somebody else", 10, 20));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message + "\nSome of the students were not added to the class list.");
                Console.WriteLine();
                Console.ResetColor();
            }

            // Task 4
            Console.WriteLine($"Class name: {classRoom.ClassName}, " +
                              $"Semester beginn: {classRoom.SemesterStart.ToShortDateString()} \n");
            Console.WriteLine("Enrolled students:");
            foreach (var student in classRoom.ClassList)
            {
                Console.WriteLine($"Student Name: {student.Name} \n\t Birthday: {student.BirthDay}.{student.BirthMonth}.");
            }

            Console.WriteLine();
            classRoom.BirthsPerSeason(classRoom.ClassList);
            
            Console.WriteLine("\nPress any key to close console...");
            Console.ReadKey();
        }

        // Task 6
        //private static void BirthsPerSeason(List<Student> students)
        //{
        //    var result = students.GroupBy(s => Season(s.BirthMonth)).Select(g => new
        //    {
        //        Season = g.Key,
        //        Amount = g.Count()
        //    });

        //    Console.WriteLine("Birthdays in each season:");
        //    foreach (var season in result)
        //    {
        //        Console.WriteLine($"{season.Season}: {season.Amount} birthdays");
        //    }
        //}

        // Task 5
        //public static string Season(int month)
        //{
        //    if (month > 2 && month < 6) return "Spring";
        //    if (month > 5 && month < 9) return "Summer";
        //    if (month > 8 && month < 12) return "Autumn";
        //    return "Winter";
        //}

        //private static string SeasonNew(int month)
        //{
        //    switch (month)
        //    {
        //        case >=3:
        //            return "Spring";
        //        case >= 6:
        //            return "Summer";
        //        case >= 9:
        //            return "Autumn";
        //        default:
        //            return "Winter";
        //    }
        //}
    }
}
