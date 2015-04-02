using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMethod
{
    public delegate void ShowX(string showX);
    public delegate void ShowY(string showY);
    public delegate void ShowIterations(string showIterations);

    public class FibMethod
    {
        double func(double x)
        {
            double f;
            //return f = Math.Pow(2*x, 2) + 3 * (Math.Pow(5 - x, (4 / 3)));  
            return f = 20 * x - 5 * Math.Pow(x, 2) + 8 * Math.Pow(x, 5 / 4);
        }

        public void Solver(ShowX showx, ShowY showy, ShowIterations showIterations)
        {
            const double e = 0.001;

            FibMethod function = new FibMethod();

            int F1, F0, F, N; // F1=F[n-1], F0=F[n-2]
            double x1, x2, y1, y2, x, y, a, b;

            //Console.WriteLine("Нижний интервал: ");
            a = 3;

            //Console.WriteLine("Верхний интервал: ");
            b = 3.5;

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
            y1 = function.func(x1);
            y2 = function.func(x2);

            do
            {
                if (y1 < y2)
                {
                    b = x2;
                    x2 = x1;
                    y2 = y1;
                    x1 = a + b - x2;
                    y1 = function.func(x1);
                }
                else
                {
                    a = x1;
                    x1 = x2;
                    y1 = y2;
                    x2 = a + b - x1;
                    y2 = function.func(x2);
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
            y1 = function.func(x1);
            x = (a + b) / 2;
            y = function.func(x);

            showx(string.Format("x= {0}", x));
            showy(string.Format("y= {0}", y));
            showIterations(string.Format("Итераций: {0}", N));
        } 
    }
}
