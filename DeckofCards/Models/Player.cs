using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.DeckofCards.Models
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; } = new List<Card>();
        public int Score => Cards.Select(c => c.CardValue).Sum();

        public void ShowPlayerCards()
        {
            Console.WriteLine($"Player {Name} has Cards- ");
            for (int i=0;i<Cards.Count();i++)
            {
                Console.WriteLine($"{Cards[i].DisplayName} of {Cards[i].CardSuit}");
            }
        }
    }
}
