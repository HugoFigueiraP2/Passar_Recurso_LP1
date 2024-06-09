using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dungeon
{
    public interface IRoom
    {
        int CountNPCsOfType<T>() where T : INPC;
        
    }
}