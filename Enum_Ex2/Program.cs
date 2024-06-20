using System;
using System.Collections.Generic;

namespace Enum_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player.players.Add(new Player("Hugo", 200));
            Player.players.Add(new Player("Gustavo", 150));
            Player.players.Add(new Player("Roberto Marreco", 250));

            Player.players.Sort();

            foreach (Player player in Player.HighScore(10))
            {
                Console.WriteLine($"Name: {player.Name} || Score: {player.Score}");
            }


        }
    }
}
