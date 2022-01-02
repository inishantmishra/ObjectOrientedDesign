using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.DeckofCards.Models
{
    public class Deck
    {
        List<Card> Cards { get; set; }

        public int CardCount => Cards.Count();

        public Deck()
        {
            Cards = new List<Card>();
            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                if (suit == Suit.NA)
                {
                    Cards.Add(new Card { CardSuit = Suit.NA, CardValue = 0, DisplayName="Joker" });
                    Cards.Add(new Card { CardSuit = Suit.NA, CardValue = 0, DisplayName = "Joker" });
                }
                else
                {
                    for (int i = 1; i <= 13; i++)
                    {
                        string displayName;
                        switch (i)
                        {
                            case 1:displayName= "Ace";
                                break;
                            case 11:
                                displayName = "Jack";
                                break;
                            case 12:
                                displayName = "Queen";
                                break;
                            case 13:
                                displayName = "King";
                                break;
                            default: displayName = i.ToString();
                                break;
                        }
                        Cards.Add(new Card() { CardSuit = suit, CardValue = i, DisplayName = displayName });
                    }
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i=0;i<Cards.Count();i++)
            {
                int randmNo = rand.Next(Cards.Count-1);
                Card temp = Cards[i];
                Cards[i] = Cards[randmNo];
                Cards[randmNo] = temp;
            }
            
        }

        public void ShowCards()
        {
            for(int i=0;i<Cards.Count;i++)
            {

                Console.WriteLine($"{Cards[i].DisplayName} of {Cards[i].CardSuit}");
            }
            Console.WriteLine("Total Cards- " + Cards.Count());

            Console.WriteLine("-----------------------------------------------------------");
        }

        public Card DealCard()
        {
            if (Cards.Count() == 0)
                return null;


            Card card = Cards.First();
            Cards.Remove(card);
            return card;
        }


        public List<Player> DealCard(List<Player> players, int noOfCards)
        {
            if (Cards.Count() == 0)
                return null;

            foreach(Player player in players)
            {
                for(int n=0;n<noOfCards;n++)
                {

                    Card card = Cards.First();
                    Cards.Remove(card);
                    player.Cards.Add(card);
                }
            }

            return players;
        }
    }
}
