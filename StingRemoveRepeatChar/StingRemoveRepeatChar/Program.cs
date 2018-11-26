using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingRemoveRepeatChar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt - Given a string, remove any repeated letters.

            string newString = "Hello World!";
            Console.WriteLine(newString);

            List<char> present = new List<char>();
            foreach (char c in newString)
            {
                if (present.Contains(c))continue;
                newString += c.ToString();
                present.Add(c);
            }

            Console.WriteLine(newString);
            Console.ReadLine();

        }
    }
}
