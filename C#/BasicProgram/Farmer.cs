using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Farmer
    {
        int chicken, cow, pigs;
        int legs;
        public Farmer(int chicken,int cow, int pigs) 
        {
            this.Chicken = chicken;
            this.Cow = cow;
            this.Pigs = pigs;
        }

        public int Chicken { get => chicken; set => chicken = value; }
        public int Cow { get => cow; set => cow = value; }
        public int Pigs { get => pigs; set => pigs = value; }
        public int Legs { get => legs; set => legs = value; }

        public int total()
        {
            Legs=(this.Chicken*2)+(this.Cow*4)+(this.Pigs*4);
            return legs;
        }
    }
}
