using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test01
{
    public class AlternatingCoins
    {
        int count = 0;
        public int solution(int[] A)
        {
            int minSequance = 0;
            int startBit0 = 0;
            int startBit1 = 1;
            int num0 = 0;
            int num1 = 0;
            num0 = bitSequance(A, startBit0);
            num1 = bitSequance(A, startBit1);

            if (num0 <= num1)
            {
                minSequance = num0;
            }
            else
            {
                minSequance = num1;
            }
            return minSequance;
            //
        }

        private int bitSequance(int[] a, int startBit)
        {
            count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != startBit)
                {
                    flip(a[i]);
                    count++;
                }
                startBit = flip(startBit);
            }
            return count;
        }

        public static int flip(int num)
        {
            if(num == 0)
            {
                num = 1;
            }
            else
            {
                num = 0;
            }
            // if num == 0 then write 1 if it's not 0 then write 0
            //return (num == 0) ? 1 : 0;
            return num;
        }

        public int originSolution(int[] A)
        {
            int sequance = 0;

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
        }


    } // end of AlternatingCoins
}
