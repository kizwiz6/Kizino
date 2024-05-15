using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kizino
{
    /// <summary>
    /// Interface for comparing cards
    /// </summary>
    public interface ICardComparer
    {
        int Compare(Card card1, Card card2);
    }
}
