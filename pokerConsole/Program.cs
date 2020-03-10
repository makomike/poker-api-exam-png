using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokerAPI;

namespace pokerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            new Deck();
            Player mako =  new Player("Mako");
            new Player("Paula");
            Console.ReadLine();
        }
    }
}
