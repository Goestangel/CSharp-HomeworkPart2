using System;

namespace _14PrinttheASCIITable
{
    class PrinttheASCIITable
    {
        static void Main()
        {
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
