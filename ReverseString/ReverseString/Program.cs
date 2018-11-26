using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt - Given a string, reverse it.

            //initiate the string
            string theString = "Hello World!";
            Console.WriteLine(theString);

            //Break Sting into character array then reverses array
            char[] characterArray = theString.ToCharArray();
            Array.Reverse(characterArray);
            Console.WriteLine(characterArray);
            Console.ReadLine();
           
        }
    }
}
