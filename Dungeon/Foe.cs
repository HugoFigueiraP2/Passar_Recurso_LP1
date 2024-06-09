using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeon
{
    public class Foe : INPC
    {
        public void Attack(INPC target, bool isSpecial = false, params INPC[] party)
        {
            throw new NotImplementedException();
        }
    }
}