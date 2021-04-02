using System;

namespace CSharp_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * ESCAPE CHARACTERS
             * \n - new line
             * \t - tab
             * \\ - backslash
             * \' - single quote
             * \" - double quote
             * VERBATIM STRINGS
             * add "@" to use single \ instead of \\
             */

            var firstName = "Jake";
            var lastName = "Nguyen";
            // String and string is the same, but String is from the System namespace that you must import
            // String lastName = "Nguyen";
            // string myName = "Jake";
            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            // var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var text = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
