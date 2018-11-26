using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt :Given an array of integers, write a method to total the odd numbers.//

            Stack<int> intlist = new Stack<int>();

            intlist.Push(2);
            intlist.Push(5);
            intlist.Push(7);
            intlist.Push(4);
            intlist.Push(1);

            int sum = 0;

            foreach (int number in intlist)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number + " is an odd number");
                    sum += number;
                }
            }

            Console.Write("The sum of these odd numbers is " + sum);
            Console.Read();

        }
    }
}
