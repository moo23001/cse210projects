using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            var optionAsString = Console.ReadLine();
            bool success = int.TryParse(optionAsString, out option);
            if (success){
                switch(option){
                    case 1:
                        string descriptionB = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                        Breathing b = new Breathing("breathing",descriptionB);
                        Console.Clear();
                        b.Welcome();
                        Console.WriteLine();
                        Console.WriteLine(b.GetDescription());
                        Console.WriteLine();
                        b.Pause(5);
                        int timeB = b.SessionTime();
                        Console.Clear();
                        Console.WriteLine ("Get ready... ");
                        b.Animation();
                        b.BreatheInOut(timeB);
                        b.Animation();
                        b.EndMessage();
                        b.Animation();
                        break;
                    case 2:
                        string descriptionR = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
                        Reflection r = new Reflection("reflection",descriptionR);
                        Console.Clear();
                        r.Welcome();
                        Console.WriteLine();
                        Console.WriteLine(r.GetDescription());
                        Console.WriteLine();
                        r.Pause(5);
                        int timeR = r.SessionTime();
                        Console.Clear();
                        Console.WriteLine ("Get ready... ");
                        r.Animation();
                        Console.Clear();
                        r.SetPrompts();
                        r.SetQuestions();
                        Console.WriteLine(r.GetPrompt());
                        r.Pause(5);
                        r.DisplayQuestions(timeR);
                        r.EndMessage();
                        r.Animation();
                        break;
                    case 3:
                        string descriptionL = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                        Listing l = new Listing("listing",descriptionL);
                        Console.Clear();
                        l.Welcome();
                        Console.WriteLine();
                        Console.WriteLine(l.GetDescription());
                        Console.WriteLine();
                        l.Pause(5);
                        int timeL = l.SessionTime();
                        Console.Clear();
                        Console.WriteLine ("Get ready... ");
                        l.Animation();
                        Console.Clear();
                        l.SetListingPrompts();
                        l.SetListedItems(timeL);
                        l.DisplayNumberOfItems();
                        l.Animation();
                        break;

                    case 4:
                        Console.WriteLine("\n\nThanks for using the Midfulness program");
                        break;
                    default:
                        break;                

                }

            } else {
                Console.Write("This is not an option number. Enter an option from 1 - 4. Press enter to continue...");
                Console.ReadLine();
                continue;
            }
        } while(option != 4);
    }


}