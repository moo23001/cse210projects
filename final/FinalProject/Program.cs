using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        while (answer != "quit")
        {
            Console.Clear();
            Console.WriteLine($"Enter the players' names\n");
            Console.Write($"Enter Player 1 name: ");
            string player1 = Console.ReadLine();
            Console.Write($"Enter Player 2 name: ");
            string player2 = Console.ReadLine();

            Console.Clear();
            Console.Clear();
            Game game = new Game(player1, player2);
            game.StartGame();

            while (game.GetWinner() == null)
            {
                game.PlayTurn();
            }

            Player winner = game.GetWinner();
            Console.WriteLine($"The winner is: {winner.GetPlayerName()}");

            Console.Write($"\nPress enter to play gain or type quit to end: ");
            answer = Console.ReadLine();

        }

    }
}