using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD1
{
    class Formula
    {
        private double a;
        private double b;
        private double c;
        public Formula(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public double A
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }
        private double ElevarCuadrado()
        {
            return this.b * this.b;
        }
        private double Multiplicar()
        {
            return 4 * this.a * this.c;
        }
        private double Raiz()
        {
            return Math.Sqrt(ElevarCuadrado() - Multiplicar());
        }
        public double ResultadoX()
        {
            return (Raiz() - this.b) / (2*this.a);
        }
        public double ResultadoY()
        {
            return (Raiz() + this.b)*(-1) / (2*this.a);
        }
    }
}
