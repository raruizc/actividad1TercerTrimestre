using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public double Sumar(double n1, double n2)
        {
            double S;
            S = n1 + n2;
            return S;
        }

        public double Restar(double n1, double n2)
        {
            double R;
            R = n1 - n2;
            return R;
        }
        public double Multiplicar(double n1, double n2)
        {
            double M;
            M = n1 * n2;
            return M;
        }

        public double Dividir(double n1, double n2)
        {
            double D;
            D = n1 / n2;
            return D;
        }
        public double Porcentaje(double n1, double n2)
        {
            double P;
            P = n1 * n2 * 0.01;
            return P;
        }
        public double Factorial(double n1)
        {
            if (n1 == 0)
            {
                return 1;
            }
            else
            {
                return n1 * Factorial(n1 - 1);
            }                
        }
    }
}
