using System;

namespace ImmutableStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;
            Console.WriteLine($"x = {x}, y = {y}");
            Console.WriteLine($"x is the same as y: {object.ReferenceEquals(x, y)}");
            // The abve will return false as x and y are stored in different memory cells.

            string first = "This is a string";
            string second = first;

            Console.WriteLine($"first:  {first}");
            Console.WriteLine($"second:  {second}");
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");

            // Strings are immutable
            first.Remove(4, 5);
            Console.WriteLine($"first:  {first}");
            Console.WriteLine($"second:  {second}");
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
            // The above code will not remove the

            // The variable storing the string must be redefined
            first = first.Remove(4, 5);
            Console.WriteLine($"first:  {first}");
            Console.WriteLine($"second:  {second}");
            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
        }
    }
}
