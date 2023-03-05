using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask3Csharp
{
    internal class Helper
    {
        static public string ReadString(string question)
        {
        l1:
            Console.Write(question);
            string value = Console.ReadLine();
            if (string.IsNullOrEmpty(value))
            {
                goto l1;
            }
            return value;
        }
        static public int ReadInt1(string question, int min, int max) 
        {
            int value;
        l1:
            Console.Write(question);
            string valueStr = Console.ReadLine();

            if (!int.TryParse(valueStr, out value))
            {
                Console.WriteLine($"{valueStr} uygun yas deyil!");
                goto l1;
            }

            if(min != 0 && value < min)
            {
                Console.WriteLine($"{value} minimal {min} qebul edile biler!");
                goto l1;
            }
            if (max != 0 && value > max)
            {
                Console.WriteLine($"{value} maksimal {max} qebul edile biler!");
                goto l1;
            }
            return value;
        }   
        static public int ReadInt2(string question, int min, int max) 
        {
            int value;
        l1:
            Console.Write("Telebelerin sayini daxil et: ");
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Say duzgun daxil edilmeyib");
                goto l1;
            }
            if (min != 0 && value < min)
            {
                Console.WriteLine($"{value} minimal {min} qebul edile biler!");
                goto l1;
            }
            if (max != 0 && value > max)
            {
                Console.WriteLine($"{value} maksimal {max} qebul edile biler!");
                goto l1;
            }
            return value;
        }
    }
}
