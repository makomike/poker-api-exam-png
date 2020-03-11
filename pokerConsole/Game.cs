using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokerAPI;
namespace pokerConsole
{
     class Game
    {
        //Game factory
        public Game() {

            var deck = new Deck(); //Create a new deck of cards
            new Player("Mako", deck);
            new Player("Paula", deck);
            Console.ReadLine();
        }


    }
}
