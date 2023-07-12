using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Game game = new Game("Player 1", "Player 2");
        game.StartGame();

        while (game.GetWinner() == null){
            game.PlayTurn();
        }

        Player winner = game.GetWinner();
        Console.WriteLine($"The winner is: {winner.GetPlayerName()}");

    }
}