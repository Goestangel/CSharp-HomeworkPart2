using System;

namespace _01DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
//ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

            ushort furstrepresent = 52130;
            sbyte secondrepresent = -115;
            int thirdrepresent = 4825932;
            byte fourthrepresent = 97;
            short fifthrepresent = -10000;

            Console.WriteLine("ushort is {0} \n, sbyte is {1} \n, int is {2} \n, byte is {3} \n, short is {4}.", furstrepresent, secondrepresent, thirdrepresent, fourthrepresent, fifthrepresent);
            
        }
    }
}
