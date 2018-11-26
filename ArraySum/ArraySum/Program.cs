using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt-	Given an array of integers, write a method to sum the elements in the array, 
            //knowing that some of the elements may be very large integers.


            //Declare array to accept large integers

            long[] arrayOne = { 1, 3, 5, 7000000000,9999999999999999, 15, 11, 100000000 };

            
            // Use Sum extension on their elements.
            long sum1 = arrayOne.Sum();

            Console.WriteLine(sum1);

            Console.ReadLine();
  
        }
    }
}
