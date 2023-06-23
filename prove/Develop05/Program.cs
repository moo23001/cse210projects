using System;

class Program
{
    static void Main(string[] args)
    {
        int menuOption = -1;
        Goals newGoal = new Goals();
        do{
            Console.Clear();
            MainMenu();
            Console.Write("Select a choice from the menu: ");
            var optionAsString = Console.ReadLine();
            bool success = int.TryParse(optionAsString, out menuOption);
            if (success){
                switch(menuOption){
                    case 1:
                        GoalType();
                        newGoal.CreateGoal();
                        break;
                    case 2:
                        newGoal.DisplayGoals();
                        Console.Write("Please hit enter to continue... ");
                        Console.Read();
                        break;
                    case 3:
                        
                        break;

                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:                        
                        Console.WriteLine("\n\nThanks for using the Eternal Quest program\n\n");
                        break;
                    default:
                        break;       
                }

            } else {
                Console.Write("This is not an option number. Enter an option from 1 - 4. Press enter to continue...");
                Console.ReadLine();
                continue;
            }


        }while(menuOption != 6);

        static void MainMenu(){
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
    }
        static void GoalType(){
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }
    

    }


}