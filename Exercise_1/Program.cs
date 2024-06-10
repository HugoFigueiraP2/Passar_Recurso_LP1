using System;
using System.Collections.Generic;

namespace Exercise_1
{
    
    class Program
    {
        //Exercicios_LP1
        private static void Main(string[] args)
        {
            Player player1 = new Player("Hugo", 12);
            Player player2 = new Player("Antonio", 6);
            Player player3 = new Player("Roberto", 30);
            Player player4 = new Player("Bernardo", 30);

            List<Player> current_players = new List<Player>();
            current_players.Add(player1);
            current_players.Add(player2);
            current_players.Add(player3);
            current_players.Add(player4);

            current_players.Sort();

            player1.HighScore(5, current_players);

            IEnumerable<Player> highScorers = player1.HighScore(5, current_players);



            foreach (Player player_now in highScorers)
            {
                Console.WriteLine(player_now);
            }
            



        }
    }
}
