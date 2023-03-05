using System.Xml;

namespace ConsoleAppTask3Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len;
            l1:
            Console.Write("Telebelerin sayini daxil et: ");
            if (!int.TryParse(Console.ReadLine(), out len) || len <= 0)
            {
                Console.WriteLine("Say duzgun daxil edilmeyib");
                goto l1;
            }
            StudentInfo[] students = new StudentInfo[len];

            students[0] = new StudentInfo();
            students[0].name= "Elvin";
            students[0].surname= "Mustafayev";
            students[0].age= 28;
            students[0].speciality= "Fizik";
            students[0].groupNo= "Fz34";

            StudentInfo student2 = new StudentInfo();
            student2.name = "Ilkin";
            student2.surname = "Yusifov";
            student2.age = 29;
            student2.speciality = "Fizik";
            student2.groupNo = "Fz34";
            students[1] = student2;

            students[2] = new StudentInfo()
            {
                name = "dart",
                surname = "this is pro langs"
            };
           
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(students[i]);
            }

            //StudentInfo student1 = new StudentInfo();
            //student1.name = "Elvin";
            //student1.surname = "Mustafayev";
            //student1.age = 28;
            //student1.speciality = "Fizik";
            //student1.groupNo = "Fz34";

            //Console.WriteLine(student1);
            //Console.WriteLine(student2);
        }
    }
}