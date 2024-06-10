using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_2
{
    public class Cat : Animal , IMammal
    {
        public int NumberOfNipples {get;} = 6;

        public override string Sound()
        {
            return base.Sound() + "Miauuuu";
        }

        
    }


}