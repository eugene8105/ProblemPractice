using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {   
        static void Main(string[] args)
        {
            //AlternatingCoins ts = new AlternatingCoins();

            //int[] a = new int[] { 1, 0, 1, 0, 1, 1 };
            //int[] b = new int[] { 0, 1, 1, 0 };
            //int[] c = new int[] { 1, 1, 0, 0 };
            //
            //ts.solution(a);
            //ts.solution(b);
            //ts.solution(a);
            //AngryFrogs af = new AngryFrogs();
            //

            AngryFrogs af = new AngryFrogs();

            int[] a = new int[] { 2, 6, 8, 5 };             // whould return 3 start index 0
            int[] b = new int[] { 1, 5, 5, 2, 6 };          // whould return 4 start index 3
            int[] c = new int[] { 1, 1};                    // whould return 2 start index 1

            //af.solution(a, 0);
            af.solution(b, 3);
            //af.solution(c, 1);
        }

    }
}