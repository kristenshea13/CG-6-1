using System;

namespace CG_6_1_namebuilder2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            Console.WriteLine(); //added a space for legibility
            //ask them their first name, declare as string and assign a name to it, same for last name
            Console.Write("Please type your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please type your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(); //added a space for legibility
            //print method return to console
            Console.WriteLine("My name is: {0}", FullName(firstName, lastName));
            


            Console.ReadLine();
        }
        /// <summary>
        /// use string builder to combine two values, first and last name, into one string
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>user entered first name + user entered last name in one string</returns>
        private static System.Text.StringBuilder FullName(string firstName, string lastName)
        {
            //had to use system.text.stringbuilder to make it work
            System.Text.StringBuilder nameCombined = new System.Text.StringBuilder(firstName + " " + lastName);
            return nameCombined;

        }



    }
}
