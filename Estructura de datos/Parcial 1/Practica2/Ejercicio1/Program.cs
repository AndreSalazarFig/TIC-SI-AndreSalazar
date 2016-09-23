using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
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
                        Console.WriteLine("Bienvenido, seleccione una opción");
                        Console.WriteLine("");
                        Console.WriteLine("1. Búsqueda de factorial");
                        Console.WriteLine("2. Sucesión de Fibonacci");
                        Console.WriteLine("3. Búsqueda del Máximo Común Divisor (MCD)");
                        Console.WriteLine("");
                        try { opcion = Convert.ToInt32(Console.ReadLine());
                            if (opcion == 1)
                            {
                                goto case 1;
                            }
                            if (opcion == 2)
                            {
                                goto case 2;
                            }
                            if (opcion == 3)
                            {
                                goto case 3;
                            }
                        }
                        catch { Console.WriteLine("Selección inválida");  }
                        
                    }
                    goto case 0;
                case 1:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese un número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num >= 0) { Console.WriteLine("El factorial es: \n" + factorial(num, -1, 1)); }
                        else { Console.WriteLine("El número debe ser mayor o igual a 0"); }
                        Console.ReadLine();
                    }
                    goto case 0;
                case 2:
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese un número");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num > 0)
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
                        else { Console.WriteLine("El número debe ser mayor o igual a 1"); }
                        Console.ReadLine();
                    }
                    goto case 0;
                case 3:
                    {
                        Console.WriteLine("");
                        int a, b;
                        Console.WriteLine("Introduce primer numero: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce segundo numero: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El Máximo Común Divisor es: " + mcd(a, b));
                        Console.ReadLine();
                    }
                    goto case 0;
                case 4:
                    {
                        
                    }
                    goto case 0;
                default:
                    {
                        Console.WriteLine("No ha seleccionado una opción disponible");
                        Console.ReadLine();
                    }
                    goto case 0;
            }

            
        }

        public static int factorial(int num, int cont, int res)
        {
            if (cont == num)
            {
                return res;
            }
            cont++;
            if (cont > 0)
            {
                res = res * cont;
            }
            return factorial(num, cont, res);
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
                    if (cant >= 3 && (cont == 3))
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

        public static int mcd(int num1, int num2)
        {
            int valor;
            if (num1 == 0)
            {
                valor = num2;
            }
            else
            {
                valor = mcd(num2 % num1, num1);
            }
            return valor;
        }
    }
}
