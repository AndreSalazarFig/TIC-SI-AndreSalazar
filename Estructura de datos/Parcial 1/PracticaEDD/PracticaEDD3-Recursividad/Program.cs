using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEDD3_Recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.WriteLine("Ingrese un número");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Recursivos oRec = new Recursivos();
            Console.WriteLine(oRec.factorial(n));
            Console.WriteLine(oRec.factorialRecursivo(m));
            Console.WriteLine("---------");
            oRec.algoRecursivo(m);
            Console.ReadKey();
        }

        
    }
}
