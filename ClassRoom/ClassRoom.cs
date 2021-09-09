using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class ClassRoom
    {
        public ClassRoom()
        {
            ClassList = new List<Student>();
        }

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }

        public void BirthsPerSeason(List<Student> students)
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
        public string Season(int month)
        {
            if (month > 2 && month < 6) return "Spring";
            if (month > 5 && month < 9) return "Summer";
            if (month > 8 && month < 12) return "Autumn";
            return "Winter";
        }
    }
}
