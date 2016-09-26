using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplos
{
    class Arreglo
    {
        int numeroFilas = 0, numeroColumnas = 0;
        int[,] arreglos;

        public int NumeroFilas
        {
            get
            {
                return numeroFilas;
            }

            set
            {
                numeroFilas = value;
            }
        }

        public int NumeroColumnas
        {
            get
            {
                return numeroColumnas;
            }

            set
            {
                numeroColumnas = value;
            }
        }

        public int[,] Arreglos
        {
            get
            {
                return arreglos;
            }

            set
            {
                arreglos = value;
            }
        }

        public Arreglo()
        {

        }

        

    }
}
