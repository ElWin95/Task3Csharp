using System.Xml;

namespace ConsoleAppTask3Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = Helper.ReadInt2("Telebelerin sayini daxil et: ", 1, 10);
 
            StudentInfo[] students = new StudentInfo[len];

            for (int i = 0; i < students.Length; i++)
            {
                StudentInfo student = new StudentInfo();

                student.name = Helper.ReadString($"{i + 1}. Ad: ");
                student.surname = Helper.ReadString($"{i + 1}. Soyad: ");
                student.age = Helper.ReadInt1($"{i + 1}. Yasi: ", 17, 40);
                student.speciality = Helper.ReadString($"{i + 1}. Ixtisasi: ");
                student.groupNo = Helper.ReadString($"{i + 1}. Qrup nomresi: ");

                students[i] = student;
            }

            Console.WriteLine("=======================================");
           
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