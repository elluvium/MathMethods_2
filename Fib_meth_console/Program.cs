using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubicApproxLibrary;

namespace Fib_meth_console
{
    class Program
    {
        static void Main(string[] args)
        {             
            
            //rate = CubicApproximation.Solve(0.001, 3, 3.5, x => 20 * x - 5 * Math.Pow(x, 2) + 8 * Math.Pow(x, 5.0 / 4.0));
            
            //rate = CubicApproximation.Solve(0.001, 3, 3.5, x => 20 * x - 5 * Math.Pow(x, 2) + 8 * Math.Pow(x, 5.0 / 4.0));
            
            //---------
            //rate = CubicApproximation.Solve(0.001, 1.5, 2, x => Math.Pow(2 * x, 2) + 3 * (Math.Pow(5 - x, (4 / 3))));
            //Console.WriteLine(rate);
            //---------
                        

            //QubicalInterpolation fr = new QubicalInterpolation(3, 3.5);
            //double testc = fr.Solve(x => 20 * x - 5 * Math.Pow(x, 2) + 8 * Math.Pow(x, 5.0 / 4.0));
            //Console.WriteLine(testc); 

            //Fibonacci.Solve(0.001, 3, 3.5, out valueX, out valueY, out iterations, x => 20 * x - 5 * Math.Pow(x, 2) + 8 * Math.Pow(x, 5 / 4));
                        
        }
    }
}
