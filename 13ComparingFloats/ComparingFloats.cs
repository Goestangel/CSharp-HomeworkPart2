using System;

namespace _13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

            bool result = false;
            //Console.WriteLine("\u2192");
            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());
            //string sNumber1 = Convert.ToString(number1);
 
            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());
 
            double deduction = number1 - number2;
            deduction = Math.Abs(deduction);
            Console.WriteLine(deduction);
            if (deduction < 0.000001) 
            {
                result = true;
            }
            Console.WriteLine("({0};{1})\u2192{2}", number1, number2, result);
        }
    }
}
