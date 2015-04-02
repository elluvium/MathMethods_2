using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib_Library
{
    public class Fibonacci
    {
        public static void Solve(double e, double a, double b, out double x, out double y, out int N, Func<double, double> function)
        { 
            int F1, F0, F; // F1=F[n-1], F0=F[n-2]
            double x1, x2, y1, y2;       
            

            double Fn = (b - a) / e;
            F0 = 1; F1 = 1;
            F = 0; N = 0;

            while (F < Fn)
            {
                F = F1 + F0; //fib num
                if (F < Fn)
                {
                    F0 = F1;
                    F1 = F;
                }
            }

            x1 = a + F0 * (b - a) / F;
            x2 = a + F1 * (b - a) / F;
            y1 = function(x1);
            y2 = function(x2);

            do
            {
                if (y1 < y2)
                {
                    b = x2;
                    x2 = x1;
                    y2 = y1;
                    x1 = a + b - x2;
                    y1 = function(x1);
                }
                else
                {
                    a = x1;
                    x1 = x2;
                    y1 = y2;
                    x2 = a + b - x1;
                    y2 = function(x2);
                }
                N++;
            }

            while (b - a > e);

            if (y1 <= y2)
            {
                b = x2;
                x2 = x1;
                y2 = y1;
            }
            else
            {
                a = x1;
            }

            x1 = x2 - e;
            y1 = function(x1);
            x = (a + b) / 2;
            y = function(x);
                     
        }
    }
}
