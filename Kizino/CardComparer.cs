using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kizino
{
    /// <summary>
    /// Class implementing card comparison logic.
    /// </summary>
    public class CardComparer : ICardComparer
    {
        public int Compare(Card card1, Card card2)
        {
            if (card1.Rank == card2.Rank)
            {
                return card1.Suit.CompareTo(card2.Suit);
            }
            return card1.Rank.CompareTo(card2.Rank);
        }
    }
}
