using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] basteballPlayers = new Player[]
            {
                new Player("Kevin Panter",20),
                new Player("Zack Leday",34),
                new Player("Matias Lesor", 43),
                new Player("Dante Exum", 23),
                new Player("Nanelly",19),
                new Player("Alen Smailagic",22)
            };

            Coach basketaballCoach = new Coach("Zeljko Obradovic", 63);

            BasketballTeam basketballTeam= new BasketballTeam(teamName: "PARTIZAN", city: "Belgrade", championshipTitles: 10, players: basteballPlayers, coach: basketaballCoach);

            Console.WriteLine("Basketball Team Infortamion: ");
            Console.WriteLine($"Team name:{basketballTeam.TeamName}");
            Console.WriteLine($"City:{basketballTeam.City}");
            Console.WriteLine($"Championships Titles:{basketballTeam.ChampionshipTitles}");
            Console.WriteLine();
            Console.WriteLine("Players: ");
            foreach( Player player in basteballPlayers) 
            {
                Console.WriteLine($"Name: {player.Name}\n Age: {player.Age}\n");
            }

            Console.WriteLine($"Coach Info: {basketballTeam.Coach.Name}\n Age: {basketballTeam.Coach.Age}");
            Console.WriteLine();

            int basketballTotalAtendence = 1000;
            double baskteballEarnings=basketballTeam.CalaculateEarnings(basketballTotalAtendence);
            Console.WriteLine($"Basketball Team Earnings: {baskteballEarnings} $");

            Console.WriteLine("************************************");

            Player[] footballPlayers = new Player[]
            {
                new Player("Ivica Kralj",30),
                new Player("Nikola Malbasa",29),
                new Player("Milovan Cirkovic",32),
                new Player("Taribo West", 35),
                new Player("Zoran BATA Mirkovic",40),
                new Player("Igor Duljaj",27),
                new Player("Sasa Ilic",45),
                new Player("Vladimir Ivic", 37),
                new Player ("Leonardo",25),
                new Player("Ivica Iliev",33),
                new Player("Aleksandar Mitrovic",27)

                
            };
            
            Coach footballCoach = new Coach("Marko Nikolic", 43);

            FootballTeam footballTeam= new FootballTeam(teamName: "F.C.PARTIZAN", lastMatches: new int[] { 1,1,1,1,0,1}, players: footballPlayers, coach: footballCoach);

            Console.WriteLine("Football Club Information:");
            Console.WriteLine($"Team name: {footballTeam.TeamName}");
            Console.WriteLine("Last (6) Matches: ");
            Console.WriteLine();
            foreach (var match in footballTeam.LastMatches)
            {
                Console.WriteLine($"{footballTeam.GetMatchResault(match)}");
            }
            Console.WriteLine();
            Console.WriteLine("Players: ");
            foreach( Player player in footballPlayers)
            {
                Console.WriteLine($"Player name: {player.Name}\n Age: {player.Age}");

            }
            Console.WriteLine();
            int footballTotalAttendance = 10000;
            double footballEarnigs=footballTeam.CalculateEarnings(footballTotalAttendance);
            Console.WriteLine($"Football Club earnings: {footballEarnigs} $");
            Console.ReadLine();






        }
    }
}
