using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment1 = new Assignment("Pedro Moo","Inheritance");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Julius Cesar", "Algebra", "2.1", "1-16");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Hapyy Gilmore", "Writing", "The Ins and Outs of Life");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}