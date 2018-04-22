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
            foreach(var kid in players)
            {
                Console.WriteLine($"{kid.Team.Mascot} has the player {kid.FullName}");
            }

            Console.WriteLine("Team Records");

            var team = db.Teams;
            foreach(var team in Teams)
            {

            }
        }
    }
}
