using System;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string courseName = "Learn C# for Beginners Crash Course";
            string message = "Welcome to ";

            // Concatenation
            string fullMessage = message + courseName;
            Console.WriteLine(fullMessage);

            // Interplation
            string fullMessage2 = $"{message}{courseName}";
            Console.WriteLine(fullMessage2);

            // Composite Formatting
            Console.WriteLine("Hello, and {0}the {1}", message, courseName);

            for (int i = 0; i < courseName.Length; i++)
            {
                char character = courseName[i];
                Console.WriteLine(character);
            }


            // Case insensitive comparison
            int position;

            position = courseName.IndexOf(" c", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(position);

            
            
        }
    }
}
