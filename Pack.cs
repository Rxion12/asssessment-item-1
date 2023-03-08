using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        public void Deck()
        {
            Reset();
        }

        public List<Card> Cards { get; set; }
        public void Reset()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                       .Select(c => new Card()
                                       {
                                           Suit = (Suit)s,
                                           Value = (Value)c
                                       }
                                              )
                                       )
                .ToList();
        }
        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 1)
            {
                return true;
            }
            else if (typeOfShuffle == 2)
            {
                return true;
            }
            else if (typeOfShuffle == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
            //Shuffles the pack based on the type of shuffle
        }
    }





    //public static bool shuffleCardPack(int typeOfShuffle)
    //{
    //    //Shuffles the pack based on the type of shuffle

    //}
    //public static Card deal()
    //{
    //    //Deals one card

    //}
    //public static List<Card> dealCard(int amount)
    //{
    //    //Deals the number of cards specified by 'amount'
    //}

}
