using System;

namespace _10EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
//Declare the variables needed to keep the information for a single employee using 
//appropriate primitive data types. Use descriptive names. Print the data at the console.

            string firstName;
            string familyName;
            byte age;
            char gender;
            string IDnumber;
            uint uniqueEmployeeNumber;

            firstName = "Karolyn";
            familyName = "Suarez";
            age = 23;
            gender = 'f';
            IDnumber = "8112312891";
            uniqueEmployeeNumber = 27560001;
            Console.WriteLine("{0} {1}\n{2}\n{3}\n{4}\n{5}", firstName, familyName, age, gender, IDnumber, uniqueEmployeeNumber);
        }
    }
}
