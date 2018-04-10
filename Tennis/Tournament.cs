using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    class Tournament
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int NumOfPlayers { get; set; }
        public int NumOfMatches { get; set; }
        public Referee GameMaster { get; set; }
        public Match[] MatchArray { get; set; }

        public int initialMatches(int numOfPlayers)
        {
            if (numOfPlayers % 2 != 0)
                return 0;
            return numOfPlayers / 2;
        }

        public Tournament(string name, int year, string fromDate, string toDate)
        {
            Name = name;
            Year = year;
            FromDate = DateTime.ParseExact(fromDate, "dd-MM-yyyy", null);
            ToDate = DateTime.ParseExact(toDate, "dd-MM-yyyy", null);
        }

        public void simulateTournement(Match[] arrayMatches)
        {
            Player[] winners = new Player[arrayMatches.Length];

            if (arrayMatches.Length == 2)
            {
                Console.WriteLine(winners[0] + " " + winners[1]);
            }
            else
            {
                for (int i = 0; i < arrayMatches.Length; i++)
                {
                    //Console.WriteLine(MatchArray[i].SimulateMatch());
                    winners[i] = arrayMatches[i].SimulateMatch();
                }
                foreach (var winner in winners)
                {
                    Console.WriteLine(winner);
                }
            }

            
        }

        public void addPlayer()
        {

        }

        public void removePlayer()
        {

        }


    }
}
