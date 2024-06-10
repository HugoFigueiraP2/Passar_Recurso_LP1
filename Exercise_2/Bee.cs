using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings{get;} = 4;
        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }
    }
}