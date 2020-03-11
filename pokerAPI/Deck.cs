using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{

    public class Deck:Card
    {

       
         List<Card> cardDeck;

        public Deck() {
            cardDeck = new List<Card>();

            CreateDeck();
        }

        public List<Card> currentCardDeck { get { return cardDeck; } }
        
        public void CreateDeck() //Creating of deck
        {
            
            foreach (String s in suit) {
                foreach (int r in rank) {
                    _rank = r;
                    _suit = s;

                    cardDeck.Add(new Card {_rank = r,_suit=s}); //add  rank and suit
                    
                }
            }

        }

        

    }
}
