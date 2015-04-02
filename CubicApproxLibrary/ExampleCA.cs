using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CubicApproxLibrary
{
    public class QubicalInterpolation
    {
        public double Accuracy { get; set; }
        public double Left_border { get; set; }
        public double Right_border { get; set; }
        public double Delta { get; set; }

        public QubicalInterpolation(double Left_border, double Right_border, double Accuracy = 0.00001)
        {
            if (Right_border < Left_border)
            {
                this.Left_border = Right_border;
                this.Right_border = Left_border;
            }
            else
            {
                this.Left_border = Left_border;
                this.Right_border = Right_border;
            }
            if (Math.Abs(Right_border - Left_border) < Accuracy)
            {
                throw new Exception("Левая и правая границы совпадают");
            }
            this.Accuracy = Accuracy;
            this.Delta = ((Math.Abs(this.Left_border - this.Right_border)) / this.Right_border);
        }
        public QubicalInterpolation(double Left_border, double Right_border, double Delta, double Accuracy = 0.00001)
        {
            if (Right_border < Left_border)
            {
                this.Left_border = Right_border;
                this.Right_border = Left_border;
            }
            else
            {
                this.Left_border = Left_border;
                this.Right_border = Right_border;
            }
            if (Math.Abs(Right_border - Left_border) < Accuracy)
            {
                throw new Exception("Левая и правая границы совпадают");
            }
            this.Accuracy = Accuracy;
            if (Delta > 0)
            {
                this.Delta = Delta;
            }
            else
            {
                throw new Exception("Шаг изменения Х не должен быть меньше 0");
            }
        }

        private double differential(Func<double, double> function, double x)
        {
            double res;
            return res = (function(x + Accuracy) - function(x)) / Accuracy;
        }

        private double Mue(ref double[] x, Func<double, double> function)//:D
        {
            double[] f = new double[2];
            double[] differentials = new double[2];
            double z;
            double w;
            for (int i = 1; i < x.Length; i++)
            {
                f[i - 1] = function(x[i]);
                differentials[i - 1] = differential(function, x[i]);
            }
            z = ((3 * (f[0] - f[1])) / (x[2] - x[1])) + differentials[0] + differentials[1];
            w = Math.Sqrt(Math.Pow(z, 2) - differentials[0] * differentials[1]);
            if (x[1] > x[2])
            {
                w *= -1;
            }
            return (differentials[1] + w - z) / (differentials[1] - differentials[0] + 2 * w);
        }

        public double Solve(Func<double, double> function)
        {
            //Initialization
            double[] x = new double[3];

            x[0] = this.Left_border + this.Accuracy;//выбор начальной точки следует заменить поскольку алгоритм предусматривает ход как влево так и вправо
            double eps1 = 10000 * Accuracy;
            double eps2 = eps1 * 2;
            double mue;
            int k = 0;
            IEnumerable<double> tmp = x;
            List<double> temp_x = new List<double>(tmp);

            if (differential(function, x[0]) > 0)
            {
                this.Delta *= -1;
            }
            do
            {
                temp_x[k + 1] = temp_x[k] + Math.Pow(2, k) * this.Delta;
                temp_x.Add(0);
                if (temp_x[k + 1] > this.Right_border)
                {
                    throw new Exception("Х находится за пределами массива " +
                        "необходимо уменьшить шаг изменения х либо увеличить интервал");
                }
                k++;
                if (k > 2000)//Да да, магическое число, но если будут предложения как это сбалансировать я с радостью прийму их
                {
                    throw new Exception("Решения на заданном отрезке не существует," +
                        " либо выбрана слишком маленький шаг");
                }
            } while (differential(function, temp_x[k - 1]) * differential(function, temp_x[k]) > 0);
            x[x.Length - 2] = temp_x[k - 1];
            x[x.Length - 1] = temp_x[k];
            while (true)
            {
                mue = Mue(ref x, function);
                if (mue - 1 > Accuracy)
                {
                    x[0] = x[1];
                }
                else
                {
                    if (mue < Accuracy)
                    {
                        x[0] = x[2];
                    }
                    else
                    {
                        x[0] = x[2] - mue * (x[2] - x[1]);
                    }
                }
                while (function(x[0]) - function(x[1]) >= Accuracy)//проверить все жити проверки с точностью а то чот палево
                {
                    x[0] -= (1 / 2) * (x[0] - x[1]);
                }
                if ((Math.Abs(differential(function, x[0])) <= eps1) && (Math.Abs((x[0] - x[1]) / x[0]) <= eps2))
                {
                    return x[0];
                }
                else
                {
                    if (differential(function, x[0]) * differential(function, x[1]) < 0)
                    {
                        x[2] = x[1];
                        x[1] = x[0];
                    }
                    if (differential(function, x[0]) * differential(function, x[2]) < 0)
                    {
                        x[1] = x[0];
                        x[2] = x[2];
                    }
                }
            }
            return 1;
        }

    }
}
