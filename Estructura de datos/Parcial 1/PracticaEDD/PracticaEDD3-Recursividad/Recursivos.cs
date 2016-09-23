using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD3_Recursividad
{
    class Recursivos
    {
        public int factorial(int n)
        {
            int fact = 1;
            for (int i = 2; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public int factorialRecursivo(int n)
        {
            if ((n == 0) || (n == 1))
            {
                return 1;
            }
            else
            {
                return (n * factorialRecursivo(n - 1));
            }
        }

        public int algoRecursivo(int n)
        {
            Console.WriteLine(n);
            if (n > 0)
            {
                return algoRecursivo(n - 1);
            }
            else { return 0; }
        }
    }
}
