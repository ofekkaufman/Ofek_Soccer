
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
            Dictionary<string, Club> clubs = new Dictionary<string, Club>();
            clubs["Maccabi_Netanya"] = new Club() { Id = 0, Name = "Maccabi Netanya", Country = "Israel", TrophyCount = 5, Stadium = "Netanya Stadium" };
            clubs["Maccabi_Tel_Aviv"] = new Club() { Id = 1, Name = "Maccabi Tel Aviv", Country = "Israel", TrophyCount = 26, Stadium = "Bloomfield Stadium" };
            clubs["Beitar_Jerusalem"] = new Club() { Id = 2, Name = "Beitar Jerusalem", Country = "Israel", TrophyCount = 6, Stadium = "Teddy Stadium" };
            clubs["Hapoel_Beer_Sheva"] = new Club() { Id = 3, Name = "Hapoel Beer Sheva", Country = "Israel", TrophyCount = 6, Stadium = "Turner Stadium" };
            clubs["Hapoel_Tel_Aviv"] = new Club() { Id = 4, Name = "Hapoel Tel Aviv", Country = "Israel",TrophyCount = 13, Stadium = "Bloomfield Stadium" };
            clubs["Hapoel_Haifa"] = new Club() { Id = 5, Name = "Hapoel Haifa", Country = "Israel", TrophyCount = 1,Stadium = "Sammy Ofer Stadium" };
            clubs["Maccabi_Haifa"] = new Club() { Id = 6, Name = "Maccabi Haifa", Country = "Israel", TrophyCount = 15, Stadium = "Sammy Ofer Stadium" };
            clubs["Bnei_Sakhnin"] = new Club() { Id = 7, Name = "Bnei Sakhnin", Country = "Israel", TrophyCount = 1, Stadium = "Doha Stadium" };
            clubs["Ironi_Kiryat_Shmona"] = new Club() { Id = 8, Name = "Ironi Kiryat Shmona", Country = "Israel", TrophyCount = 1, Stadium = "Ironi Kiryat Shmona Stadium" };
               

            List <Player> players = new List<Player>();
            players.Add(new Player() { Name = "Samu da silva", Id = 1, Club = clubs["Maccabi_Netanya"], Goals = 0, Position = "GK" });
            players.Add(new Player() { Name = "Dor Peretz", Id = 2, Club = clubs["Maccabi_Tel_Aviv"], Goals = 6, Position = "MID" });
            players.Add(new Player() { Name = "Dor Hugi", Id = 3, Club = clubs["Maccabi_Netanya"], Goals = 1, Position = "FWD" });
            players.Add(new Player() { Name = "Dolev Haziza", Id = 4, Club = clubs["Maccabi_Netanya"], Goals = 0, Position = "FWD" });

            //linq
            var clubsWithMaccabi = clubs.Values
                .Where(c => c.Name.StartsWith("Maccabi", StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine("Maccabi clubs:");

            clubsWithMaccabi.ForEach(c => Console.WriteLine(c.Name));



        }
    }
}
