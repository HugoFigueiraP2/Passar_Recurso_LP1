using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Enum_Ex2
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; set; }

        // Lista de jogadores como propriedade da classe Player
        public static List<Player> players = new List<Player>();

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        // Método para obter jogadores com pontuação superior ao mínimo
        public static IEnumerable<Player> HighScore(int min_score)
        {
            foreach (Player cur_player in players)
            {
                if (cur_player.Score > min_score)
                {
                    yield return cur_player;
                }
            }
        }
    }

}
