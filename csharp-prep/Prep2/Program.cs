using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? (Use only whole postive numbers from 1 - 100) ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        string letter =  "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        string sign = "";
        if (!(percentage >= 100 || percentage < 60))
        {
            int remainder = percentage % 10;
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            sign = "";
        }
        
        Console.WriteLine($"Your grade is {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You can do this. Try again!");
        }
    }
}