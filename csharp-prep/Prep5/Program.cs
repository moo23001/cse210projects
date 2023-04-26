using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
                DisplayResult(PromptUserName(),SquareNumber(PromptUserNumber()));
    }
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        
        static String PromptUserName()
        {
            Console.Write("Enter your name: ");
            String userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            String userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int squared;
            squared = userNumber * userNumber;
            return squared;
        }

        static void DisplayResult(string userName, int favNumber)
        {
            Console.WriteLine($"{userName} the square of your number is {favNumber}");
        }
}