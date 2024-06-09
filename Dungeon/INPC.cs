using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeon
{
    public interface INPC
    {
        void Attack(INPC target, bool isSpecial = false, params INPC[] party);
    }
}