using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Gamble
    {
        double prob;
        int prize, pay;

        public Gamble(double prob, int prize, int pay) 
        {
            this.prob = prob;
            this.prize = prize;
            this.pay = pay;

        }
    }
}
