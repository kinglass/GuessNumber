using System;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {  
            numberGame();
            binSearchNumberGame();
            Console.ReadLine();
        }
        /// <summary>
        /// TODO: Create a Binary Search version of the guess number game which will require less guesses than the version below.
        /// </summary>
        private static void binSearchNumberGame()
        {
                     
        }
        /// <summary>
        /// Best case will solve in one guess
        /// worse case will solve in 50 guesses
        /// </summary>
        private static void numberGame()
        {
            
            Random rnd = new Random();
            int randNum = rnd.Next(1, 50);
            bool flag = true;
            do
            {
                try
                {
                    Console.WriteLine("Guess the number between 0 and 50");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == randNum)
                    {
                        Console.WriteLine("You guessed the right number");
                    }
                    else if (guess < randNum)
                    {
                        Console.WriteLine("Your guess is too low");
                    }
                    else if (guess > randNum)
                    {
                        Console.WriteLine("Your guess is too high");
                    }
                    else if (guess < 0 || guess > 50)
                    {
                        Console.WriteLine("Must be between 0 and 50");
                    }
                }catch (FormatException)
                {
                    Console.WriteLine("Failed to input an integer");
                }
            } while (flag);
        }
    }
}
