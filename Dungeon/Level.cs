using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeon
{


    public class Level
    {
        private readonly IList<INPC> npcs;

        private readonly IList<IRoom> rooms; 


        public int NPCCount 
        {
            get { return npcs.Count; }
        }

        public Level()
        {
            npcs = new List<INPC>();

            rooms = new List<IRoom>();

        }        


        public int CountNPCsOfTypeInAll<T>() where T: INPC
        {
            int totalNPCs = 0;

            foreach(IRoom room in rooms)
            {
                totalNPCs += room.CountNPCsOfType<T>();
            }

            return totalNPCs;
        }

   

    }

}