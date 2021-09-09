using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private int _birthMonth;

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }
        
        public string Name { get; private set; }
        public int BirthDay { get; private set; }

        public int BirthMonth
        {
            get => _birthMonth;
            private set
            {
                if (value >= 1 && value <=12)
                {
                    _birthMonth = value;
                }
                else 
                    throw new ArgumentOutOfRangeException("Birth Month", "The month must be between 1 and 12.");
            }
        }
    }
}
