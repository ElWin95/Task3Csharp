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

            for (int i = 0; i < students.Length; i++)
            {
                StudentInfo student = new StudentInfo();

                student.name= Helper.ReadString($"{i+1}. Ad: ");
                student.surname= Helper.ReadString($"{i+1}. Soyad: ");

                Console.Write($"{i + 1}. Soyadd: ");
                student.surname = Console.ReadLine();
                int age;
            l2:
                Console.Write($"{i + 1}. Yas: ");
                string strAge = Console.ReadLine();
                if (!int.TryParse(strAge, out age) || age < 17)
                {
                    Console.WriteLine($"{strAge} uygun yas deyil!");
                    goto l2;
                }
                Console.Write($"{i + 1}. Ixtisas: ");
                student.speciality = Console.ReadLine();
                Console.Write($"{i + 1}. Qrup nomresi: ");
                student.groupNo = Console.ReadLine();
                students[i] = student;
            }

            Console.WriteLine("===========================");
           
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