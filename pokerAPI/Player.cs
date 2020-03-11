using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Player:Card
    {

        List<Card> playerhand;
        Deck _deck;

        private string _name;


        public Player(string name,Deck deck) {
             
            _name = name;
            _deck = deck;
            playerhand = new List<Card>();
            Console.WriteLine("=================");
            dealPlayer();
            Console.WriteLine("=================");
        }


        public void dealPlayer() {

            int playerCardCount ;
            for (playerCardCount = 0; playerCardCount < 5; playerCardCount++) {
                playerhand.Add(_deck.currentCardDeck[playerCardCount]);
            }

            _deck.currentCardDeck.RemoveRange(0, 5);
           

            foreach (Card s in _deck.currentCardDeck) {
                Console.WriteLine(s._rank + s._suit);            
            }

            

        }





    }
}
