using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class AngryFrogs
    {
        public int solution(int[] blocks, int frogIndex)
        {
            //int frogIndex = 0;
            
            int numOfJumps = 1;
            // first frog
            for (int i = frogIndex + 1; i < blocks.Length; i++)
            {
                if(blocks[i] >= blocks[i - 1])
                {
                    numOfJumps++;
                }
            }
            // second frog
            for (int i = frogIndex - 1; i > blocks.Length; i--)
            {
                if (blocks[i] >= blocks[i + 1])
                {
                    numOfJumps++;
                }
            }

            return numOfJumps;
        }

    } // end of AngryFrogs
}
