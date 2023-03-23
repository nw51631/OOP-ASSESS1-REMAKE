using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;

        public Pack()
        {
            Packs = new List<Pack>()
            int numSuits = Enum.GetNames(typeof(Suit)).Length;
            int numKinds = Enum.GetNames(typeof(Kind)).Length;
            
            for (int suit = 0; suit < numSuits; suit++)
            {
                for (int kind = 0; kind < numKinds; kind++)
            {
                Packs.Add(new Pack((Kind)kind, (Suit)suit));
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            Random random = new Random();
            int n = CountCardsInDeck;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card randomCard = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = randomCard;
            }
        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
