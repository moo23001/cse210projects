using System;

class Program
{
    static void Main(string[] args)
    {
        string answer;
        
        do {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1,101);
            int guess = -1;
            int attempts = 0;
            do 
            {
                Console.Write("Guess the magic number: ");
                String userInput = Console.ReadLine();
                guess = int.Parse(userInput);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                attempts++;
            } while (guess != magicNumber);
            
            Console.WriteLine($"It took you {attempts} trys to guess the magic number");

            
            Console.Write("Do you wish to play again (y/n) ");
            answer = Console.ReadLine();
        } while (answer == "y");

    }
}