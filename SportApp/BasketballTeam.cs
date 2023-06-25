using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp
{
    public class BasketballTeam
    {
        private string teamName;
        private string city;
        private int championshipTitles;
        private Player[] players;
        private Coach coach;

        const double CourthLenght = 25.0;
        const double CourthWidth = 10.0;

        public BasketballTeam(string teamName, string city, int championshipTitles, Player[] players, Coach coach)
        {
            this.TeamName = teamName;
            this.City = city;
            this.ChampionshipTitles = championshipTitles;
            this.Players = players;
            this.Coach = coach;
        }

        public string TeamName { get => teamName; set => teamName = value; }
        public string City { get => city; set => city = value; }
        public int ChampionshipTitles { get => championshipTitles; set => championshipTitles = value; }
        public Player[] Players { get => players; set => players = value; }
        public Coach Coach { get => coach; set => coach = value; }

        public double CalaculateEarnings(int totalAttendence) 
        {
            int adultCount = (int)(totalAttendence * 0.65);
            int childCount = (int)(totalAttendence * 0.35);

            double adultTicketPrice = 10.0;
            double childTicketPrice = 0.5 * adultTicketPrice;

            double adultEarnings = adultCount * adultTicketPrice;
            double childEarnings= childCount * childTicketPrice;

            double totalEarnings = adultEarnings + childEarnings;

            return totalEarnings;
        }
    }
}
