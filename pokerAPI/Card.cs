using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Card
    {

        public int[] rank = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        public string[] suit = { "D", "H", "S", "C" };

        public int _rank { get; set; }
        public string _suit { get ; set; }

    }
}
