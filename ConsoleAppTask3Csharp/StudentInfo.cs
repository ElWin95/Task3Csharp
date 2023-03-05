using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask3Csharp
{
    internal class StudentInfo
    {
        public string name;
        public string surname;
        public int age;
        public string speciality;
        public string groupNo;

        public override string ToString()
        {
            return $"{name} {surname} {age} {speciality} {groupNo}";
        }
    }
}
