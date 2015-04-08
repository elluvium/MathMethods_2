using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubicApproxLibrary
{
    public class CubicApproximation
    {

        public static double Solve(double eps, double leftBorder, double rightBorder, out int iter, Func<double, double> function)
        {
            double[] x = new double[3];
            x[0] = leftBorder + eps; //начальная точка
            IEnumerable<double> tmp = x;
            List<double> x_temp = new List<double>(tmp);
            x_temp = new List<Double>(tmp);

            double[] f = new double[3]; //функция
            double[] f_der = new double[3];   //производная      

            double dx; //дельта
            double EPS = 0.000001;
            double e1, e2;
            double x_stat = 0;
            int k = 0;
            iter = 0;

            dx = (Math.Abs(leftBorder - rightBorder)) / rightBorder; //шаг
            e1 = 10000 * eps; //параметр сходимости
            e2 = e1 * 2;

            //шаг1            
            if ((((function(x[0] + EPS) - function(x[0])) / EPS)) < 0)
                do
                {
                    x_temp[k + 1] = x_temp[k] + Math.Pow(2, k) * dx;
                    x_temp.Add(0);
                    k++;
                    iter++;
                }

                while ((((function(x_temp[k - 1] + EPS) - function(x_temp[k - 1])) / EPS)) * (((function(x_temp[k] + EPS) - function(x_temp[k])) / EPS)) <= 0);

            else
                do
                {
                    x_temp[k + 1] = x_temp[k] - Math.Pow(2, k) * dx;
                    x_temp.Add(0);
                    k++;
                    iter++;
                }
                while ((((function(x_temp[k - 1] + EPS) - function(x_temp[k - 1])) / EPS)) * (((function(x_temp[k] + EPS) - function(x_temp[k])) / EPS)) <= 0);

            //шаг2
            for (int i = 0; i <= x_temp[k]; i++)
            {
                function(x_temp[k]);
                iter++;
            }
                

            x[x.Length - 2] = x_temp[k - 1];
            x[x.Length - 1] = x_temp[k];

            f[0] = function(x[1]);
            f[1] = function(x[2]);
            f_der[0] = (((function(x[1] + EPS) - function(x[1])) / EPS));
            f_der[1] = (((function(x[2] + EPS) - function(x[2])) / EPS));

            //шаг3
        step3:
            double w;
            double z = ((3 * ((f[0]) - f[1]) / (x[2] - x[1])) + f_der[0] + f_der[1]);

            if (x[1] < x[2])
                w = Math.Pow(Math.Pow(z, 2) - f_der[0] * f_der[1], 1.0 / 2.0);
            else
                w = -Math.Pow(Math.Pow(z, 2) - f_der[0] * f_der[1], 1.0 / 2.0);

            double u = ((f_der[1] + w - z) / (f_der[1] - f_der[0]) + 2 * w);

            //считаем стационарную точку
            if (u < 0)
            {
                x_stat = x[2];
            }
            if (0 <= u && u <= 1)
            {
                x_stat = x[2] - u * (x[2] - x[1]);
            }
            if (u > 1)
            {
                x_stat = x[1];
            }

            //шаг4
            if (function(x_stat) <= function(x[1]))
                goto step5;
            else
                while (function(x_stat) <= function(x[1]))
                {
                    x_stat = x_stat + 0.5 * (x_stat - x[1]);
                    iter++;
                }

            //шаг5
        step5:
            if ((((function(x_stat + EPS) - function(x_stat)) / EPS <= e1)) && Math.Abs((x_stat - x[1]) / x_stat) <= e2)
                return x[1];
            else
            {
                if (((function(x_stat + EPS) - function(x_stat)) / EPS) * (function(x[1] + EPS) - function(x[1])) < 0)
                    x[2] = x_stat;
                if (((function(x_stat + EPS) - function(x_stat)) / EPS) * (function(x[2] + EPS) - function(x[2])) < 0)
                    x[1] = x_stat;
                goto step3;
            }
        }

    }
}
