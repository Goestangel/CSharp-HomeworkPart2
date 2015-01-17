using System;

namespace _12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

            int? numberone = null;
            double? numbertwo = null;
            Console.WriteLine("{0};{1}", numberone, numbertwo);

            numberone = numberone + null;
            numbertwo = numbertwo + null;

            Console.WriteLine("{0};{1}", numberone, numbertwo);

            numberone = numberone + 100;
            numbertwo = numbertwo + 100.5;

            Console.WriteLine("{0};{1}", numberone, numbertwo);

            numberone = numberone + 100;
            numbertwo = numbertwo + 100.5;

            Console.WriteLine("{0};{1}", numberone.GetValueOrDefault(), numbertwo.GetValueOrDefault());

        }
    }
}
