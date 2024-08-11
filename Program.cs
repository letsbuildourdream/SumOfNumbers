using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int result = AddNumbers(num1, num2);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + result);
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
