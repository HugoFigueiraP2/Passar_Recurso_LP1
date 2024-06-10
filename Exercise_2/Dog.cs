using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Dog : Animal
    {
        public int NumberOfNipples {get;} = 8;
        public override string Sound()
        {
            return base.Sound() + "AuAu";
        }
    }
}