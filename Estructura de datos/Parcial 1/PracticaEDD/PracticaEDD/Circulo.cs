using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD
{
    public class Circulo : Figura 
    {
        private Double radio;
        public Circulo(double Radio)
        {
            this.radio = Radio;
        }
        public double Radio
        {
            get
            {
                return radio;
            }

            set
            {
                radio = value;
            }
        }
        public override double Area()
        {
            return Math.PI * (radio * radio);
        }
        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
