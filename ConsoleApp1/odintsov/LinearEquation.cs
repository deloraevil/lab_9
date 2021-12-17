using System;
using System.Collections.Generic;
using System.Text;

namespace odintsov
{
    class LinearEquation
    {
        protected List<float> x;

        public List<float> a_linear_equation(float a, float b)
        {
            if (a == 0)
            {
                throw new OdintsovException("Error: a = 0, Определено, что такое уравнение не существует");
            }
            OdintsovLog.I().log("Определено, что это линейное уравнение");
            return this.x = new List<float>() { (-b) / a };
        }
    }
}
