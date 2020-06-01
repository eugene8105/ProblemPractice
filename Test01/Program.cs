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
        AlternatingCoins ts = new AlternatingCoins();

            int[] a = new int[] { 1, 0, 1, 0, 1, 1 };

            int[] b = new int[] { 0, 1, 1, 0 };
            int[] c = new int[] { 1, 1, 0, 0 };


            //ts.solution(a);
            //ts.solution(b);
            ts.solution(a);
            //AngryFrogs af = new AngryFrogs();

        }

    }
}