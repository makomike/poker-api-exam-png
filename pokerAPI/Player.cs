using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Player:Deck
    {

        List<Card> playerhand;
    

        private string _name;


        public Player(string name) {
             
            _name = name;
            playerhand = new List<Card>();
         
            dealPlayer();
           
        }


        public void dealPlayer() {

            int playerCardCount ;
            for (playerCardCount = 0; playerCardCount < 5; playerCardCount++) {
                playerhand.Add(currentCardDeck[playerCardCount]);
            }

           currentCardDeck.RemoveRange(0, 5);

            foreach (Card s in currentCardDeck) {
                Console.WriteLine(s._rank + s._suit);            
            }

            

        }


    }
}
