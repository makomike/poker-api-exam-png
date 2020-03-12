using System;
using System.Collections.Generic;
using System.Text;

namespace pokerAPI
{
    public class Game
    {
        List<Player> players;//List of players
        Deck deck;
        int _playerCount = 0;
        string _playerName = "";

        public Game() {
            deck = new Deck();
            players = new List<Player>();
            getPlayers();
            printPlayers();

        }

        public void getPlayers() {

            Console.WriteLine("Enter player count: ");
            _playerCount =  Convert.ToInt32(Console.ReadLine());
           // var inx = Console.Read();
            for (int i = 0; i <_playerCount; i++)
            {
                Console.WriteLine("Enter player name: ");
               
                players.Add(new Player(_playerName, deck));
            }

      
        }


        public void printPlayers() {
            foreach (Player p in players) {
                for (int i = 0; i < 5; i++) {
                    Console.Write(p.playerHand[i]._rank + p.playerHand[i]._suit + "\t");
                }
                Console.WriteLine();
            }
        }

        

    }
}
