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
            ClassRoom classRoom = new ClassRoom()
            {
                ClassName = "Q3",
                SemesterStart = new DateTime(2019, 08, 26)
            };

            classRoom.ClassList.Add(new Student("Niko", 12, 21));
            classRoom.ClassList.Add(new Student("Adriana", 09, 08));
            classRoom.ClassList.Add(new Student("Nohely", 07, 14));
        }
    }
}
