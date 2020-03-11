using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{

    public class Deck : Card
    {


        List<Card> cardDeck;

        public Deck() {
            cardDeck = new List<Card>();

            CreateDeck();
            ShuffleDeck();
        }

        public List<Card> currentCardDeck { get { return cardDeck; } }

        public void CreateDeck() //Creating of deck
        {

            foreach (String s in suit) {
                foreach (int r in rank) {
                    _rank = r;
                    _suit = s;

                    cardDeck.Add(new Card { _rank = r, _suit = s }); //add  rank and suit

                }
            }
           
        }

        public void ShuffleDeck() {

            int i;
            int cardCount = cardDeck.Count;
            for (i = 0; i < 1000; i++)
            {
                int firstCard_Index = new Random().Next(cardCount);
                int secondCard_Index = new Random().Next(cardCount);


                if (firstCard_Index != secondCard_Index)
                {
                    List<Card> temp = new List<Card>();
                    temp.Add(cardDeck[firstCard_Index]);
                    cardDeck.Insert(firstCard_Index, cardDeck[secondCard_Index]);
                    cardDeck.Insert(secondCard_Index, temp[0]);

                }


              

            }
 

            //cardDeck.Insert(0, new Card { _rank = 1, _suit = "C" });
            int ccc =1;
            foreach (Card c in cardDeck){
                //Console.WriteLine(c._rank + c._suit + " " + ccc);
                //ccc++;
            }
           
            

        }

    }
}
