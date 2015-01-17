using System;

namespace _07QuotesinStrings
{
    class QuotesinStrings
    {
        static void Main()
        {
//Declare two string variables and assign them with following value: 
//The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.

                string withoutQuoted = "The \"use\" of quotations causes difficulties.";
                string withQuoted = @"The ""use"" of quotations causes difficulties.";
                Console.WriteLine(withoutQuoted);
                Console.WriteLine(withQuoted);

        }
    }
}
