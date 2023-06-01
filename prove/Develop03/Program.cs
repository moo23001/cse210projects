using System;

class Program
{
    static void Main(string[] args)
    {
        string mockScripture = "If ye love me, keep my commandments.";
        string mockReference = "John 14:15";
        Reference myReference = new Reference(mockReference);
        Scripture myScripture = new Scripture(mockScripture);

    

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