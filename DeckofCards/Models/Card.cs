using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.DeckofCards.Models
{
    public class Card       
    {
        public Suit CardSuit { get; set; }
        public int CardValue { get; set; }
        public string DisplayName => GetDisplayName();

        private string GetDisplayName()
        {
            string name;
            switch(CardValue)
            {
                case 0:
                    name = "Joker";
                    break;
                case 1:
                    name = "Ace of "+CardSuit ;
                    break;
                case 11:
                    name = "Jack of " + CardSuit;
                    break;
                case 12:
                    name = "Queen of " + CardSuit;
                    break;
                case 13:
                    name = "King of " + CardSuit;
                    break;
                default:
                    name = CardValue.ToString()+" of "+CardSuit;
                    break;
            }
            return name;
        }
    }
}
