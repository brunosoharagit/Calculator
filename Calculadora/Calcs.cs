using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calcs
    {
        public int Sum(int n1, int n2)
        {
            int n3;
            n3 = n1 + n2;

            return n3;
        }

        public int Sub(int n1, int n2)
        {
            int n3;
            n3 = n1 - n2;

            return n3;
        }

        public int Mul(int n1, int n2)
        {
            int n3;
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
