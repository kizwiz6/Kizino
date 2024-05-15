using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kizino
{
    /// <summary>
    /// Interface for printing cards.
    /// </summary>
    internal interface ICardPrinter
    {
        void Print(Card card);
    }
}
