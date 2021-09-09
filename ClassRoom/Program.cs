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

    }
}
