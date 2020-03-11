using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Card
    {

        public int[] rank = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 }; //rank list in an int array
        public string[] suit = { "D", "H", "S", "C" }; //suit list in a string array

        public int _rank { get; set; }//set rank of the card
        public string _suit { get ; set; } //set the suit of the card

    }
}
