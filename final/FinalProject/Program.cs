using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Game game = new Game("Player 1", "Player 2");
        game.StartGame();

    }
}