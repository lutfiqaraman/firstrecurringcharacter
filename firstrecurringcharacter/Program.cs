using System;

namespace firstrecurringcharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string astring = "ABCDD";

            FirstRepeating FR = new FirstRepeating(astring);

            char result = FR.Processing();

            if (result != '\0')
                Console.WriteLine(result);
            else
                Console.WriteLine("No first repeating");

            Console.ReadKey();
        }
    }
}