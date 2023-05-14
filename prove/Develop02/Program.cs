using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool finished = false;
        Journal myJournal = new Journal();
        List<Entry> readEntries = new List<Entry>();
        foreach (Entry e in readEntries){

            Console.WriteLine(e._dateEntry);
        }

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
                    Load(fileToLoad);
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

        return entries;
    } 
}