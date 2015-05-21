using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HookeJeevesLibrary
{
    public class HookeJeeves
    {
        public double[] xmin;
        public double xmax = 0.0;
        public int k = 1;
        public int[,] d = new int[2, 2];
        public double eps = 0.01;
        public double delta = 0.2;
        public double alfa = 1;
        public double[] z;
        public double[] y;
        public bool end=true;

        public HookeJeeves(double eps, double delta, double alfa)
        {
            d[0,0] = 1;
            d[1,0] = 0;
            d[0,1] = 0;
            d[1,1] = 1;
            this.eps = eps;
            this.delta = delta;
            this.alfa = alfa;
            this.xmin = new double[2];
            this.z = new double[2];
            this.y = new double[2];
        }
        public void attr(double[] x, double[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = y[i];
            }
        }
        public void getplz(int j)
        {
            for (int i = 0; i < 2; i++)
            {
                z[i] = y[i] + delta * d[i,j];
            }
        }
        public void getmnz(int j)
        {
            for (int i = 0; i < 2; i++)
            {
                z[i] = y[i] - delta * d[i,j];
            }
        }

        public void getMin(Function F, double[] x, int num)
        {
            end=true;
            k = 0;
            attr(y, x);
            do
            {
                int j = 0;
                for (j = 0; j < 2; j++)
                {
                    getplz(j);
                    if (F.f(z, num) < F.f(y, num))
                    {
                        attr(y, z);
                    }
                    else
                    {
                        getmnz(j);
                        if (F.f(z, num) < F.f(y, num))
                        {
                            attr(y, z);
                        }
                    }
                }
                if (F.f(y, num) < F.f(x, num))
                {
                    double[] tmp = new double[2];
                    attr(tmp, x);
                    attr(x, y);
                    for (int i = 0; i < 2; i++)
                    {
                        y[i] = x[i] + alfa * (x[i] - tmp[i]);
                    }
                   k++;
                }
                else
                if (delta <= eps)
                    {
                        end = false;
                        attr(xmin, x);
                    }
                    else
                    {
                        attr(y, x);
                        delta = delta / 2.0;  //magic number ^^
                        k++;
                    }
            }
            while (end);
        }

    }
}
