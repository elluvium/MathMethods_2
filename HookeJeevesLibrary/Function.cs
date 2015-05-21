using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HookeJeevesLibrary
{
    public class Function
    {
        public double f(double[] x, int num)
        {
            if (num == 0)
            {                
                //return x[0] * x[0] + 3*(x[1]*x[1])+ Math.Cos(x[0]+x[1]); //десятая
               // return (x[1] * x[1]) + Math.Pow(Math.E, x[0] * x[0]) + (x[1] * x[1]) + x[0] * x[1]; //девятая
                return 3 * (x[0] * x[0] * x[0]) - x[0] + (x[1] * x[1] * x[1]) - 3 * (x[1] * x[1]) - 1;  //восьмая
            }
            if (num == 1)
            {                               
                //return 100 * ((x[1] - Math.Pow(x[0], 3)) * (x[1] - Math.Pow(x[0], 3))) + (1 - x[0]) * (1 - x[0]);    //шестая                           

                //return 3 * (x[0] * x[0] * x[0]) - x[0] + (x[1] * x[1] * x[1]) - 3 * (x[1] * x[1]) - 1;  //восьмая
                return (x[1] * x[1]) + Math.Pow(Math.E, x[0] * x[0]) + (x[1] * x[1]) + x[0] * x[1]; //девятая
            }
            return 0;
        }
    }
}
