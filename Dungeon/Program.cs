using System;

namespace Dungeon
{
    class Program
    {   

        /// <summary>
        /// Ex 1.4
        /// 1. Definir as classes 
        /// 2. definir numero
        /// 3. obter resultado das instancias de Foe
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            // 1. 
            Level myLevel = new Level();

            // 2.
            int foeInstances = 0;

            // 3.
            foeInstances = myLevel.CountNPCsOfTypeInAll<Foe>();

            // responsta teste 
            int foeInstancesT = myLevel.CountNPCsOfTypeInAll<Foe>();

        }
    }
}
