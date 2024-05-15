using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kizino
{
    internal class CardPrinter : ICardPrinter
    {
        public void Print(Card card)
        {
            Console.WriteLine($"{card.Rank} of {card.Suit}"); ;
        }
    }
}
