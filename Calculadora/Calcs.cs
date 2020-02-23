using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calcs
    {
        public double Sum(double n1, double n2)
        {
            double n3;
            n3 = n1 + n2;

            return n3;
        }

        public double Sub(double n1, double n2)
        {
            double n3;
            n3 = n1 - n2;

            return n3;
        }

        public double Mul(double n1, double n2)
        {
            double n3;
            n3 = n1 * n2;

            return n3;
        }

        public double Div(double n1, double n2)
        {
            double n3;
            n3 = n1 / n2;

            return n3;
        }
    }
}
