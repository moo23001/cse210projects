using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string password = "myPass.1";
        bool answer = false;
        do {
            Console.Write("Enter the password: ");
            string userInput = Console.ReadLine();
            if (userInput == password) {
                answer = true;
                
            }
        } while (!answer);

        bool finished = false;
        Journal myJournal = new Journal();
        Console.Clear();
        Console.WriteLine("Welcome!");
        do {
            
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Please choose an option: ");
            int option = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (option)
            {
                case 1:
                        Question newQuestion = new Question();
                        string myPrompt = newQuestion.Prompt();
                        Console.WriteLine(myPrompt);
                        Console.Write("> ");
                        string myEntry = Console.ReadLine();
                        DateTime now = DateTime.Now;
                        Entry thisEntry = new Entry();
                        thisEntry._textEntry = myEntry;
                        thisEntry._dateEntry = now.ToString("F");
                        thisEntry._prompt = myPrompt;
                        myJournal._entries.Add(thisEntry);
                        Console.Clear();
                        break;
                case 2:
                    myJournal.Display();
                    break;
                case 3:
                    Console.Write("Enter the name of the file: ");
                    string fileToLoad = Console.ReadLine();
                    myJournal._entries = Load(fileToLoad);
                    Console.WriteLine("Choose option 2 to display loaded entries");
                    break;
                case 4:
                    Console.Write("Enter the name of the file: ");
                    string filename = Console.ReadLine();
                    Save(filename,myJournal._entries);
                    break; 
                case 5:
                    Console.WriteLine("Thank for using your Journal");
                    finished = true;
                    break;               
            }


        } while(!finished);
    }

    public static void Save(string filename, List<Entry> entries)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in entries){
                outputFile.WriteLine($"{e._dateEntry}±{e._prompt}±{e._textEntry}");
            }
        }
    }

    public static List<Entry> Load(string filename)
    {
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines){
            string[] parts = line.Split("±");

            Entry newEntry = new Entry();
            newEntry._dateEntry = parts[0];
            newEntry._prompt = parts[1];
            newEntry._textEntry = parts[2];
            
            entries.Add(newEntry);
        }

        return entries;
    } 
}