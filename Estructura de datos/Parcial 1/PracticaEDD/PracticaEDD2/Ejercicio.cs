using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD2
{
    class Ejercicio : Racional
    {
        
        public double resultado;

        public Ejercicio()
        {
        }

        public override double CrearRacional(Double a, Double b)
        {
            return a / b;
        }

        public override double Suma(double r1, double r2)
        {
            resultado = r1 + r2;
            return resultado;
        }

        public override double Multiplicar(double r1, double r2)
        {
            resultado = r1 * r2;
            return resultado;
        }

        public override bool EsIgual(double r1, double r2)
        {
            if (r1 != r2)
            {
                return false;
            }
            return true;
        }
    }
}
