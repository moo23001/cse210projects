using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Enter a scripture reference: ");
        string scriptureReference = Console.ReadLine();
        Console.WriteLine("Enter the scripture text");
        string scriptureText = Console.ReadLine();
        //string mockScripture = "If ye love me, keep my commandments.";
        //string mockReference = "John 14:15";
        Reference myReference = new Reference(scriptureReference);
        Scripture myScripture = new Scripture(scriptureText);

    

        bool answer = true;
        while (myScripture.AllWordsHidden(myScripture.GetScripture()) && answer ){
            Console.Clear();
            myReference.DisplayReference();
            myScripture.DisplayScripture();
            Console.Write("\n\nPress enter to hide words... ");
            string next = Console.ReadLine();
            next.ToLower();
            if (next == "quit"){
                answer = false;
            } else {
                myScripture.HideWord(myScripture.GetScripture());
            }
            

        }
        Console.Clear();
        myReference.DisplayReference();
        myScripture.DisplayScripture();

 
    }

}