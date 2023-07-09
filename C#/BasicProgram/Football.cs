using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Football
    {
        int wins, draws, losses, points;

        public Football(int wins,int draws,int losses)
        {
            this.wins = wins;
            this.draws = draws;
            this.losses = losses;
        }
        public int score()
        {
            if(wins<0 || draws<0 || losses<0)
            {
                return -1;
                
            }
            else
            {
                points = wins * 3 + draws * 1 + losses * 0;
                return points;

            }
            
        }
    }
}
