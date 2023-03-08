using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public enum Value
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    public enum Suit
    {
        Club = 1,
        Spade = 2,
        Heart = 3,
        Diamond = 4,
    }
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }
    }
    
}

