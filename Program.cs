using System;

namespace Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var randNum = r.Next(1, 101);
            var guessed = false;
            var tries = 0;
            while (guessed != true) {
                Console.WriteLine("What number am I thinking of (between 1 and 100)?");
                string guessStr = Console.ReadLine();
                tries += 1;
                int guess;
                if (int.TryParse(guessStr, out guess) == true) {
                    if (guess > randNum) {
                        Console.WriteLine("That's too high!");
                    } else if (guess < randNum) {
                        Console.WriteLine("That's too low!");
                    } else if (guess == randNum) {
                        Console.WriteLine("Correct! You guessed it in "+tries+" tries!");
                        guessed = true;
                    }
                } else {
                    Console.WriteLine("Please enter a number...");
                }
            }
        }
    }
}
