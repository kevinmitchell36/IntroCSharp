using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);  // Will print the numbers 0 to 4 in the terminal
            }

            for (; ; )
            {
               // Creates infinite loop by giving no sections
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i);
            }


            int i = 0;
            while (i < 10){

                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine(i);

            // The initializer (int i = 0) is accesible outside of the block

        }
    }
}
