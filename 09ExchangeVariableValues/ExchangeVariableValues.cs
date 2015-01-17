using System;

namespace _09ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            
//Declare two integer variables a and b and assign them with 5 and 10 and after that 
//exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

            int numberone = 5;
            int numbertwo = 10;

            Console.WriteLine("Before exchange \u2192 number1={0}\tnumber2={1}", numberone, numbertwo);

            int numberthree;
            numberthree = numberone;
            numberone = numbertwo;
            numbertwo = numberthree;

            Console.WriteLine("After exchange \u2192 number1={0}\tnumber2={1}", numberone, numbertwo);
        }
    }
}

        
    

