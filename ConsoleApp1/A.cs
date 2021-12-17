using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class A
    {
        protected double x;

        public double a_linear_equation(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("Error: a = 0");
            }
            this.x = (-b) / a;
            return this.x;
        }
    }
}
