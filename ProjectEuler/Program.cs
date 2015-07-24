using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        static void Main(string[] args)
        {
            Utility utility = new Utility();

            EulerSolver eulerSolver = new EulerSolver();
            int answer = 0;

            //answer = eulerSolver.Problem1();
            //answer = eulerSolver.Problem2();
            
            Stopwatch sw = Stopwatch.StartNew();

            answer = eulerSolver.Problem7();

            var elapsedMilliseconds = sw.ElapsedMilliseconds;

            Console.WriteLine(answer);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("elapsed: {0} ms", sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
