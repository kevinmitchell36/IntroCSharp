using System;

namespace StringEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "This is a string";
            string second = "THIS IS A STRING";

            // Tests sameness
            Console.WriteLine(first == second);
            Console.WriteLine(second == first);

            // Tests value
            Console.WriteLine(first.Equals(second));
            Console.WriteLine(second.Equals(first));
        }
    }
}
