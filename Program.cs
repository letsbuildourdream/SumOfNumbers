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
            /* int num1 = 5;
             int num2 = 10;
             int result = AddNumbers(num1, num2);
             Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + result);*/

            //First Change of adding user Input
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int resultAdd = AddNumbers(num1, num2);
            int resultSubtract = SubtractNumbers(num1, num2);

            /* Console.WriteLine($"The sum of {num1} and {num2} is: {resultAdd}");

             //Second Change of subtracting statement 
             Console.WriteLine($"The difference between {num1} and {num2} is: {resultSubtract}");*/

            //modify the Console.WriteLine statements to use string interpolation.
            Console.WriteLine($"The sum of {num1} and {num2} is: {resultAdd}");
            Console.WriteLine($"The difference between {num1} and {num2} is: {resultSubtract}");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
        //Second Change of subtracting function 
        static int SubtractNumbers(int a, int b)
        {
            return a - b;
        }
    }
}
