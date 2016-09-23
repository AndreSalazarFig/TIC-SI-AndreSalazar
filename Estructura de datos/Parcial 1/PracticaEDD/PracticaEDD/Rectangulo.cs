using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD
{
    public class Rectangulo:Figura
    {
        private double bases;
        private double altura;

        public double Bases
        {
            get
            {
                return bases;
            }

            set
            {
                bases = value;
            }
        }

        public double Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }
        public Rectangulo(double Base, double Altura)
        {
            this.altura = Altura;
            this.bases = Base;
        }
        public override double Area()
        {
            return (bases * altura);
        }
        public override double Perimetro()
        {
            return ((bases * 2) + (altura * 2));
        }
    }
}
