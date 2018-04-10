using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player("Kvist", "Hansen", "10-06-1996", "dansk", Gender.Male);
            Player player2 = new Player("Jens", "Måge", "10-06-1996", "dansk", Gender.Male);
            Player player3 = new Player("Jalle", "Skagen", "10-06-1996", "dansk", Gender.Male);
            Player player4 = new Player("Gustav", "Pedersen", "10-06-1996", "dansk", Gender.Male);
            Player player5 = new Player("Andreas", "Hansen", "10-06-1996", "dansk", Gender.Male);
            Player player6 = new Player("Kage", "Due", "10-06-1996", "dansk", Gender.Male);
            Player player7 = new Player("Karl", "Jensen", "10-06-1996", "dansk", Gender.Male);
            Player player8 = new Player("Bæ", "Hansen", "10-06-1996", "dansk", Gender.Male);

            Player[] listPlayer = { player1, player2, player3, player4, player5, player6, player7, player8 };
            

            Referee referee1 = new Referee("kalle", "bøv", "hansen", "10-06-1996", Gender.Male, "10-06-1995", "10-06-1995");

            Match match1 = new Match(listPlayer[0], listPlayer[1], referee1);
            Match match2 = new Match(listPlayer[2], listPlayer[3], referee1);
            Match match3 = new Match(listPlayer[4], listPlayer[5], referee1);
            Match match4 = new Match(listPlayer[6], listPlayer[7], referee1);

            Match[] listMatches = { match1, match2, match3, match4};

            Tournament tournament1 = new Tournament("test", 1999, "10-06-1996", "10-06-1996");

            tournament1.simulateTournement(listMatches);

            //Console.WriteLine(match1.ToString());
            
            /*for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(match1.SimulateMatch());
                Console.WriteLine();
            } */

        }
    }
}

