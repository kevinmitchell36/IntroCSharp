using System;

namespace BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int minimum {int.MinValue}, maximum {int.MaxValue}");
            Console.WriteLine($"long minimum {long.MinValue}, maximum {long.MaxValue}");

            Console.WriteLine();

            Console.WriteLine($"float minimum {float.MinValue}, maximum {float.MaxValue}");
            Console.WriteLine($"double minimum {double.MinValue}, maximum {double.MaxValue}");

            Console.WriteLine();


        }
    }
}
