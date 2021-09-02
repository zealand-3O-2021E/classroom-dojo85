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

            // Task 4
            Console.WriteLine($"Class name: {classRoom.ClassName}, Semester beginn: {classRoom.SemesterStart}");
            Console.WriteLine("Enrolled students:");
            foreach (var student in classRoom.ClassList)
            {
                Console.WriteLine($"Student Name: {student.Name}, Birthday: {student.BirthDay}.{student.BirthMonth}.");
            }

            CountBirthsPerSeason(classRoom.ClassList);
            

        }

        // Task 5
        private static string Season(int month)
        {
            if (month > 2 && month < 6) return "Spring";
            if (month > 5 && month < 9) return "Summer";
            if (month > 8 && month < 12) return "Autumn";
            return "Winter";
        }

        // Task 6
        private static void CountBirthsPerSeason(List<Student> students)
        {
            Dictionary<string, int> birthSeasons = new Dictionary<string, int>(4);

            foreach (var student in students)
            {
                string season = Season(student.BirthMonth);
                if (!birthSeasons.Keys.Contains(season))
                {
                    birthSeasons.Add(season, 1);
                }
                else
                {
                    birthSeasons[season] += 1;
                }
            }

            foreach (var season in birthSeasons)
            {
                Console.WriteLine(season.Key + ", " + season.Value);
            }
        }
    }
}
