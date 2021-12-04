using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = false;
            bool y = true;
            bool z = true;

            bool a = x && y || z;
            Console.WriteLine(a);

            int number = 5;
            if (number == 4 && true)
            {
                Console.WriteLine("WTF!");
            }
        }
    }
}
