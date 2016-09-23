using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            switch (opcion)
            {
                case 0:
                    {
                        Console.WriteLine("Bienvenido, seleccione la opción que desee");
                        Console.WriteLine("");
                        Console.WriteLine("1. Ejercicio 1");
                        Console.WriteLine("2. Ejercicio 2");
                        Console.WriteLine("3. Ejercicio 3");
                        Console.WriteLine("4. Ejercicio 4");
                        Console.WriteLine("5. Ejercicio 5");
                        Console.WriteLine("6. Ejercicio 6");
                        Console.WriteLine("7. Ejercicio 7");
                        Console.WriteLine("");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 1) { goto case 1; }
                        if (opcion == 2) { goto case 2; }
                        if (opcion == 3) { goto case 3; }
                        if (opcion == 4) { goto case 4; }
                        if (opcion == 5) { goto case 5; }
                        if (opcion == 6) { goto case 6; }
                        if (opcion == 7) { goto case 7; }
                    }
                    goto case 0;
                case 1:
                    {
                        
                        Console.WriteLine("");
                    }
                    goto case 0;
                case 2:
                    {

                        Console.WriteLine("");
                    }
                    goto case 0;
                case 3:
                    {

                        Console.WriteLine("");
                    }
                    goto case 0;
                case 4:
                    {

                        Console.WriteLine("");
                    }
                    goto case 0;
                case 5:
                    {

                        Console.WriteLine("");
                    }
                    goto case 0;
                case 6:
                    {

                        Console.WriteLine("");
                    }
                    goto case 0;
                case 7:
                    {

                        Console.WriteLine("");
                    }
                    goto case 0;
                default:
                    {
                        Console.WriteLine("No ha seleccionado una opción válida, se le regresará al menú principal");
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    goto case 0;

            }
        }




    }
}
