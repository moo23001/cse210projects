using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> numbers = new List<int>();
        String loopflag = "notbreak";
        int total = 0;
        Double average = 0;
        do {
            Console.Write("Enter a number: ");
            String userInput = Console.ReadLine();
            int enteredNumber = int.Parse(userInput);
            if (enteredNumber != 0)
            {
                numbers.Add(enteredNumber);
                loopflag = "notbreak";
            }
            else
            {
                loopflag = "break";
            }

        } while (loopflag == "notbreak");

        total = numbers.Sum();
        int max = numbers.Max();
        average = numbers.Average();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

    }
}