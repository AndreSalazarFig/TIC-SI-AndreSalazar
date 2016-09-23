using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD2
{
    abstract class Racional
    {
        public Racional() { }
        abstract public double CrearRacional(Double a, Double b);
        abstract public double Suma(double r1, double r2);
        abstract public double Multiplicar(double r1, double r2);
        abstract public bool EsIgual(double r1, double r2);
    }
    
}
