namespace Kizino
{
    /// <summary>
    /// Enum for the card suits
    /// </summary>
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    /// <summary>
    /// Enum for card ranks
    /// </summary>
    public enum Rank
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card(Suit.Hearts, Rank.Ace);
            Card card2 = new Card(Suit.Diamonds, Rank.Five);
            Card card3 = new Card(Suit.Clubs, Rank.Ten);
            Card card4 = new Card(Suit.Spades, Rank.Jack);
            Card card5 = new Card(Suit.Hearts, Rank.Two);

            // Creating instances of CardComparer and CardPrinter
            ICardComparer comparer = new CardComparer();
            ICardPrinter printer = new CardPrinter();

            // Printing the cards
            Console.WriteLine("Printing Cards:");
            printer.Print(card1);
            printer.Print(card2);
            printer.Print(card3);
            printer.Print(card4);
            printer.Print(card5);
            Console.WriteLine();

            // Comparing cards
            Console.WriteLine("Comparing Cards:");
            Console.WriteLine($"Comparing card1 and card2: {comparer.Compare(card1, card2)}");
            Console.WriteLine($"Comparing card2 and card3: {comparer.Compare(card2, card3)}");
            Console.WriteLine($"Comparing card1 and card3: {comparer.Compare(card1, card3)}");
            Console.WriteLine($"Comparing card4 and card5: {comparer.Compare(card4, card5)}");
        }
    }
}
