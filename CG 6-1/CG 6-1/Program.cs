using System;
using System.Text;

namespace CG_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for their first name and hold the data
            Console.WriteLine("Please type your first name: ");
            string firstName = Console.ReadLine();

            //ask the user for their last name and hold the data
            Console.WriteLine("Please type your last name: ");
            string lastName = Console.ReadLine();

            //call the method below to string together the data that you held to create the full name on screen
            Console.WriteLine(GiveFullName(firstName, lastName));
            Console.ReadLine();

        }
        /// <summary>
        /// take the answer to first name and last name and make it one full name
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>full name</returns>
        private static string GiveFullName(string firstName, string lastName)
        {
            //stringBuilder allows you to create a string by taking up less memory
            StringBuilder fullName = new StringBuilder();
            //append adds to the copy of the string
            fullName.Append(firstName);
            fullName.Append(" ");
            fullName.Append(lastName);

            //convert full name value into a string
            string GiveFullName = fullName.ToString();
            //print out the full name to the screen
            return GiveFullName;
        }
    }
}
