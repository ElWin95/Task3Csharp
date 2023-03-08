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
            ConsoleColor defaultColor = Console.ForegroundColor;
        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(question);
            Console.ForegroundColor = defaultColor;
            string value = Console.ReadLine();
            if (string.IsNullOrEmpty(value))
            {
                goto l1;
            }
            return value;
        }
        static public int ReadInt1(string question, int min, int max) 
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            int value;
        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(question);
            Console.ForegroundColor = defaultColor;
            string valueStr = Console.ReadLine();

            if (!int.TryParse(valueStr, out value))
            {
                PrintError($"{valueStr} uygun yas deyil!");
                goto l1;
            }

            if(min != 0 && value < min)
            {
                PrintError($"{value} minimal {min} qebul edile biler!");
                goto l1;
            }
            if (max != 0 && value > max)
            {
                PrintError($"{value} maksimal {max} qebul edile biler!");
                goto l1;
            }
            return value;
        }   
        static public int ReadInt2(string question, int min, int max) 
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            int value;
        l1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Telebelerin sayini daxil et: ");
            Console.ForegroundColor = defaultColor;
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                PrintError("Say duzgun daxil edilmeyib");
                goto l1;
            }
            if (min != 0 && value < min)
            {
                PrintError($"{value} minimal {min} qebul edile biler!");
                goto l1;
            }
            if (max != 0 && value > max)
            {
                PrintError($"{value} maksimal {max} qebul edile biler!");
                goto l1;
            }
            return value;
        }
        static void PrintError(string errorMessage)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ForegroundColor = defaultColor;
        }
    }
}
