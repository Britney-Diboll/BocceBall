using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BocceeBall.Data;

namespace BocceeBall
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DataContext();
            Console.WriteLine("Welcome to Bocce Ball!");

            Console.WriteLine("All Player Information is displayed below:");
            var kids = db.Players.Include(x => x.Team);
            foreach(var kid in kids)
            {
                Console.WriteLine($"{kid.Team.Mascot} has the player {kid.FullName}");
            }

            Console.WriteLine("Team Records:");

            var teams = db.Teams;
            foreach(var team in teams)
            {
                Console.WriteLine($"{team.Mascot} have won {team.Wins} games and lost {team.Losses} games.");
            }

            Console.WriteLine("Team Schedules:");
            var pastGames = db.Games;
            foreach(var game in pastGames)
            {
                if (game.Date <= DateTime.Now)
                {
                    Console.WriteLine($"{game.HomeTeam.Mascot} played {game.AwayTeam.Mascot} on {game.Date}");
                }
                    
                if (game.Date > DateTime.Now)
                {
                    Console.WriteLine($"{game.HomeTeam.Mascot} will play {game.AwayTeam.Mascot} on {game.Date}");
                }
            }
            Console.ReadLine();
        }
    }
}
