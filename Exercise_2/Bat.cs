using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Bat : Animal, ICanFly, IMammal
    {
        public int NumberOfWings{get;} = 2;
        public int NumberOfNipples{get;} = 4;
        public override string Sound()
        {
            return base.Sound() + "FrickFrick";
        }

        
    }
}