using System;
using System.Collections.Generic;

namespace Exercise_1
{
    public class Player : IComparable<Player>
    {
        public int Score{get;set;}
        private string Name;
        

        public Player(string name, int score)
        {
            Score = score;
            Name = name;
        }

        public IEnumerable<Player> HighScore(int min, List<Player> player_list)
        {
            foreach(Player player in player_list)
            {
                if (min <= player.Score)
                {
                    yield return player;
                }
                
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public int CompareTo(Player other)
        {
            if (other == null)
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

        




    }
}