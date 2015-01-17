using System;

namespace _06StringsandObjects
{
    class StringsandObjects
    {
        static void Main()
        {
// Declare two string variables and assign them with Hello and World.
// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

            string firstWord = "Hello";
            string secondWord = "World! :D ";
            object greeting = firstWord + " " + secondWord;
            string castGreeting = (string)greeting;
            Console.WriteLine(greeting);

            
        }
    }
}
