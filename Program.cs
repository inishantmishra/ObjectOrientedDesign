using OOD.DeckofCards.Models;
using System;
using System.Collections.Generic;

namespace OOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("-----------------------------------------------------------");

            Game game = new Game();
            game.Players = new List<Player> { new Player { Name = "Nish" }, new Player { Name = "Nishant" } };
            game.NoOfCardsPerPlayer = 4;
            game.Play();

            Player player = game.GetWinner(game.Players);
            Console.WriteLine($"Winner is {player.Name} with score {player.Score}");
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
