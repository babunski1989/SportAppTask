using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp
{
    public class FootballTeam
    {
        private string teamName;
        private int[] lastMatches;
        private Player[] players;
        private Coach coach;

        const double FieldLenght = 100.0;
        const double FieldWidth = 50.0;

        public FootballTeam(string teamName, int[] lastMatches, Player[] players, Coach coach)
        {
            this.TeamName = teamName;
            this.LastMatches = lastMatches;
            this.Players = players;
            this.Coach = coach;
        }

        public string TeamName { get => teamName; set => teamName = value; }
        public int[] LastMatches { get => lastMatches; set => lastMatches = value; }
        public Player[] Players { get => players; set => players = value; }
        public Coach Coach { get => coach; set => coach = value; }

        public string GetMatchResault(int matchResault)
        {
            if (matchResault == 0)
            {
                return "Draw";
            }
            else if (matchResault == 1)
            {
                return "Win";
            }
            else if (matchResault == 2)
            {
                return "Lose";
            }
            else
            {
                return "Unknown";
            }
        }

        public double CalculateEarnings(int totalAttendence) 
        {
            int freeTicketCount = (int)(totalAttendence * 0.25);
            int paidTicketCount= totalAttendence - freeTicketCount;
            double ticketPrice = 50.0;

            double paidEarnings=paidTicketCount * ticketPrice;
            return paidEarnings;
        }
    }
}
