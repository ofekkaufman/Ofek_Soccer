
using ListEXE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEXE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Club> clubs = new List<Club>();
            clubs.Add(new Club() { Id = 1, Name = "Maccabi Netanya" });
            clubs.Add(new Club() { Id = 1, Name = "Maccabi Tel Aviv" });


            List<Player> players = new List<Player>();
            players.Add(new Player() { Name = "Samu da silva", Id = 1, Club = clubs[0], Goals = 0 });
            players.Add(new Player() { Name = "Dor Peretz", Id = 2, Club = clubs[1], Goals = 6 });
            players.Add(new Player() { Name = "Dor Hugi", Id = 3, Club = clubs[0], Goals = 1 });
            players.Add(new Player() { Name = "Dolev Haziza", Id = 4, Club = clubs[0], Goals = 0 });

            foreach (Player player in players)
            {
                if (player.Name.StartsWith("DOR", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(player.Name);
                }

            }


        }
    }
}
