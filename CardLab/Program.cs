using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLab
{
    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xCoord, int yCoord) : this()
        {
            X = xCoord;
            Y = yCoord;
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }

    public enum Suit { Spades = 9824, Clubs = 9827, Hearts = 9829, Diamonds = 9830 }

    public enum Rank { Deuce, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}

    struct Card
    {
        public Rank Rank { get; private set; }
        public Suit Suit { get; private set; }

        public Card(Rank newRank, Suit newSuit) : this()
        {
            Rank = newRank;
            Suit = newSuit;
        }

        public override string ToString()
        {
            return string.Format("{0:x} {1}", (char)Suit, Rank);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card(Rank.Six, Suit.Spades);
            Card card2 = new Card(Rank.King, Suit.Diamonds);

            Console.WriteLine(card1);
            Console.WriteLine(card2);
        }
    }
}
