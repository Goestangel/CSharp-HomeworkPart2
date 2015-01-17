using System;

namespace _02FloatorDouble
{
    class FloatorDouble
    {
        static void Main()
        {  
// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
// 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

            double firstValue = 34.567839023;
            float secodValue = 12.345f;
            double thirdValue = 8923.1234857;
            float fourthValue = 3456.091f;
            Console.WriteLine("34.567839023 = {0}", firstValue);
            Console.WriteLine("12.345 = {0}", secodValue);
            Console.WriteLine("8923.1234857 = {0}", thirdValue);
            Console.WriteLine("3456.091 = {0}", fourthValue);
        }
    }
}
    