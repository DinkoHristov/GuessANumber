using System;

namespace GuessANumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Computer move is random - between [1, 100].
            //Every time the game starts the CP chooses one random number in range [1, 100].
            Random random = new Random();
            int computerNumber = random.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This is a game called: GUESS A NUMBER");
            Console.WriteLine("Let's start playing!");
            Console.Write("Guess a number between [1, 100]: ");

            while (true)
            {
                //Reading players number and bool isValid (TryParse() method) = converts our string to int.
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                //Check if we have entered an integer number.
                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You guessed it!");
                        Console.ResetColor();
                        break;
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Too High!");
                        Console.WriteLine("Try to guess it again!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Guess a number between [1, 100]: ");
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Too Low!");
                        Console.WriteLine("Try to guess it again!");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Guess a number between [1, 100]: ");
                        continue;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Please enter a number!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Guess a number between [1, 100]: ");
                    continue;
                }
            }
        }
    }
}
