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
        public string DisplayName { get; set; }
    }
}
