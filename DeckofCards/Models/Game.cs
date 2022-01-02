using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.DeckofCards.Models
{
    public class Game
    {
        private Deck deck { get; set; }
        public List<Player> Players { get; set; }
        public int NoOfCardsPerPlayer { get; set; } = 2;
        public void Play()
        {
            deck = new Deck();
            deck.Shuffle();
            deck.ShowCards();

            //Players= new List<Player> { new Player { Name = "Nish" }, new Player { Name = "Nishant" } };

            Players= deck.DealCard(Players, NoOfCardsPerPlayer);

            foreach (var player in Players)
            {
                Console.WriteLine($"Score of {player.Name} is {player.Score}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var player in Players)
            {
                player.ShowPlayerCards();
                Console.WriteLine("-----------------------------------------------------------");
            }

        }

        public Player GetWinner(List<Player> players)
        {
            int max = 0;
            Player winner = new Player();
            foreach (var player in players)
            {
                if (player.Score > max)
                {
                    max = player.Score;
                    winner = player;
                }
            }
            if (max > 0)
                return winner;

            return null;
        }
    }
}
