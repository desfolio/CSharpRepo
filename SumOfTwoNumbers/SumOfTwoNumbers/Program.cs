using System;
using System.Runtime.CompilerServices;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Write a C# Sharp program to print the sum of two numbers.
             */

            
            Console.WriteLine("Please enter your first number: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter your second number: ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var addResult = firstNumber + secondNumber; 

            Console.WriteLine($"{firstNumber} + {secondNumber} = {addResult}");
        }
    }
}
