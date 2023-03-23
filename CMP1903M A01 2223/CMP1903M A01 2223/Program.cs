using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
    {
        CardDeck cardDeck = new CardDeck();

        CardSorter sorter = new CardSorter
        {
            SortBy = CardOrderMethod.SuitThenKind
        };
        cardDeck.Sort(sorter);
        cardDeck.WriteToConsole();

        cardDeck.Shuffle();

 
        Console.ReadKey();
    }
}
}
