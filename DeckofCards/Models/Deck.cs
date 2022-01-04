using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.DeckofCards.Models
{
    public class Deck
    {
        List<Card> cards { get; set; }

        public int CardCount => cards.Count();

        public Deck()
        {
            cards = new List<Card>();
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (suit != Suit.Joker)
                {
                    for (int i = 1; i <= 13; i++)
                    {
                        cards.Add(new Card() { CardSuit = suit, CardValue = i });
                    }
                }
            }
            cards.Add(new Card { CardSuit = Suit.Joker, CardValue = 0 });
            cards.Add(new Card { CardSuit = Suit.Joker, CardValue = 0 });
        }

        public void Shuffle()
        {
            //Random rand = new Random();
            //for(int i=0;i<cards.Count();i++)
            //{
            //    int randmNo = rand.Next(cards.Count-1);
            //    Card temp = cards[i];
            //    cards[i] = cards[randmNo];
            //    cards[randmNo] = temp;
            //}

            cards = cards.OrderBy(c => Guid.NewGuid()).ToList();
            
        }

        public void ShowCards()
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"{card.DisplayName}");
            }
            Console.WriteLine("Total Cards- " + cards.Count());

            Console.WriteLine("-----------------------------------------------------------");
        }

        public Card DealCard()
        {
            if (cards.Count() == 0)
                return null;


            Card card = cards.FirstOrDefault();
            cards.Remove(card);
            return card;
        }


        public List<Player> DealCard(List<Player> players, int noOfCards)
        {
            if (cards.Count() == 0)
                return null;

            foreach(Player player in players)
            {
                for(int n=0;n<noOfCards;n++)
                {

                    Card card = cards.First();
                    cards.Remove(card);
                    player.Cards.Add(card);
                }
            }

            return players;
        }
    }
}
