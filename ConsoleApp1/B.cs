using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class B:A
    {
        public double[] b_quadratic_equation(double a, double b, double c)
        {
            double[] x = new double[2];
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                throw new Exception("Rootless");
            }
            else if (d == 0)
            {
                x[0] = (-b) / 2 * a;
            }
            else if (a == 0)
            {
                throw new Exception("Division by 0");
            }
            else
            {
                x[0] = ((-b) + Math.Sqrt(d)) / 2 * a;
                x[1] = ((-b) - Math.Sqrt(d)) / 2 * a;
            }
            return x;
        }


        protected double discriminant(double a, double b, double c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            return d;
        }

    }
}
