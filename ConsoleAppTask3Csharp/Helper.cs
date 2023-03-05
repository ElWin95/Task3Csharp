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
    }
}
