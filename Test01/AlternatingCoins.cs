using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    public class AlternatingCoins
    {
        public int solution(int[] A)
        {
            int sequance = 0;
            int j = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (i != A.Length - 1)
                {
                    if (A[i] == 0)
                    {
                        if (A[i + 1] == 0)
                        {
                            A[i + 1] = 1;
                            sequance++;
                        }
                    }
                    else
                    {
                        if (A[i + 1] == 1)
                        {
                            A[i + 1] = 0;
                            sequance++;
                        }
                    }
                }

            }
            return sequance;
        }

        //        int sequance = 0;
        //        int j = 0;

        //                for (int i = 0; i<A.Length; i++)
        //                {
        //                    j = A[i];

        //                    if (j == 1)
        //                    {
        //                        if (A[i + 1] == j)
        //                        {
        //                            A[i + 1] = 0;
        //                            sequance++;
        //                        }
        //}
        //                }
        //                return sequance;



    } // end of AlternatingCoins
}
