using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favoriteNumber = r.Next(1,1000);
            Boolean endProgram = false;
            
            while (endProgram == false)
            {
                int userNumber = Guess();
                endProgram = CheckGuess(favoriteNumber, userNumber);
            }

            
            
        }

        static int Guess()
        {
            Console.WriteLine("");
            Console.WriteLine("Please guess a number between 1 and 1000:");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return userNumber;
         }

        static Boolean CheckGuess(int favoriteNumber, int userNumber)
        {
            if (userNumber == favoriteNumber)
            {
                Console.WriteLine("You guessed it!");
                return true;
            }
            else if (userNumber < favoriteNumber)
            {
                Console.WriteLine("Too low.");
                return false;
            }
            else if (userNumber > favoriteNumber)
            {
                Console.WriteLine("Too high.");
                return false;
            }
            else
            {
                Console.WriteLine("Never mind.");
                return true;
            }
        }
    }
}
