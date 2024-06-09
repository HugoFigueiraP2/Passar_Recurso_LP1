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


        /// <summary>
        /// 1. Criar instancia local de INPC
        /// Associar npc1 ao elemento 0 da lista (primeiro elemento)
        /// 2. Mesma coisa, só que é um IRoom
        /// 3. fazer retorno simulataneo em forma de tuplo
        /// </summary>
        /// <param name="npc"></param>
        /// <param name="Tops("></param>
        /// <returns></returns>
        public (INPC npc, IRoom room) Tops()
        {   
            // 1.
            INPC npc1;
            npc1 = npcs[0];

            // 2.
            IRoom room1;
            room1 = rooms[0];

            // 3
            return (npc1,room1);
        }

    }

}