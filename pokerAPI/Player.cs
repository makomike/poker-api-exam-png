using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Player:Card
    {

        List<Card> hand;
      
        Deck _deck;

        private string _name;

        

        public Player(string name,Deck deck) {
             
            _name = name;
            _deck = deck;
            hand = new List<Card>();
           
            dealPlayer();
            

        }

        public List<Card> playerHand { get { return hand; } }

        /// <summary>
        /// 
        /// Dealer method
        /// 
        /// </summary>

        public void dealPlayer() {

            int playerCardCount ;
            for (playerCardCount = 0; playerCardCount < 5; playerCardCount++) {
                hand.Add(_deck.currentCardDeck[playerCardCount]);
            }

            _deck.currentCardDeck.RemoveRange(0, 5);
           

            foreach (Card p in hand) {
                Console.WriteLine(p._rank + p._suit);            
            }

            

        }

        public void pickCard(string pickedCard) {

            int playerCardCount = 0;
            Console.WriteLine("Pick card for" + _name);
            for (playerCardCount = 0; playerCardCount < 5; playerCardCount++) {
                Console.WriteLine("CARD " + (playerCardCount + 1));
            }

        }



    }
}
