using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                if (num >= 3)
                {
                    Console.WriteLine("La serie de fibonacci es: \n" + fibonacci(num, 0, 3, "", 1, 1));
                }
                else
                {
                    Console.WriteLine("La serie de fibonacci es: \n" + fibonacci(num, 0, 1, "", 1, 1));
                }
            }
            else { Console.WriteLine("El número debe ser mayor o igual a 0"); }
            Console.ReadKey();
        }

        static string fibonacci(int cant, int numact, int cont, string cad, int numant, int numsig)
        {
            if (cant == 1)
            {
                cad = "0";
            }
            else
            {
                if (cant == 2)
                {
                    cad = "0, 1";
                }
                else
                {
                    if (cant >= 3 && (cont == 3) )
                    {
                        cad = "0, 1, 1";
                    }
                }
            }
            if (cont == cant)
            {
                return cad;
            }
            numact = numant + numsig;
            numant = numsig;
            numsig = numact;
            cad = cad + ", " + numact;
            cont++;
            return fibonacci(cant, numact, cont, cad, numant, numsig);
        }
    }
}
