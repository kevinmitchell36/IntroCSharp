using System;

namespace SimpleMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please choose one of the menu options");
            Console.WriteLine("1. Cappucino");
            Console.WriteLine("2. Latte");
            Console.WriteLine("3. Americano");
            Console.WriteLine("4. Mocha");
            Console.WriteLine("5. Macchiato");
            Console.WriteLine("6. Espresso");
            Console.WriteLine("Q. Quit the program");
            char userChoice = ' ';
           
            do
            {
                Console.WriteLine("Please choose one of the menu options");
                userChoice = char.ToLower(Console.ReadKey(true).KeyChar);
                Console.WriteLine("You chose " + userChoice);
            


                switch (userChoice)
                {
                    case '1':
                        Console.WriteLine("Making the Cappucino");
                        break;
                    case '2':
                        Console.WriteLine("Making the Latte");
                        break;
                    case '3':
                        Console.WriteLine("Making the Americano");
                        break;
                    case '4':
                        Console.WriteLine("Making the Mocha");
                        break;
                    case '5':
                        Console.WriteLine("Making the Macchiato");
                        break;
                    case '6':
                        Console.WriteLine("Making the Espresso");
                        break;
                    case 'q':
                        Console.WriteLine("Quiting program");
                        break;
                    default:
                        Console.WriteLine("Returning coins");
                        continue; // When triggered, this will skip over the lines 55 and 56 then read line 57.
                }
                Console.WriteLine("Dispensing coffee");
                Console.WriteLine("Have a nice day");
            } while (!userChoice.Equals('q'));
        }
    }
}
