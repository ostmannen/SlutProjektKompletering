using System;

namespace slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playGame = true;

            while(playGame)
            {
                playGame = age();

                
            }

            Console.ReadLine();
        }
        static bool age()
        {
            System.Console.WriteLine("What is your age???");

            string playerInput = Console.ReadLine();

            if (isInt(playerInput))
            {
                return false;
            }
            else {
                System.Console.WriteLine(playerInput + " is not a number.");
            }
            return true;
        }
        static bool isInt(string number)
        {
            bool success = int.TryParse(number, out int result);

            return success;
        }
    }
}
