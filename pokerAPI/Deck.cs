using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{

    public class Deck
    {

        int[] rank = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        string[] suit = { "D", "H", "S", "C" };

        private List<string> cardDeck;

        public Deck() {
            cardDeck = new List<string>();
           
        }

        public List<string> currentCardDeck { get { return cardDeck; } }
        
        public void CreateDeck() //Creating of deck
        {
         
            foreach (String s in suit) {
                foreach (int i in rank) {
                    cardDeck.Add(i+s);
                }
            }

        }

        

    }
}
