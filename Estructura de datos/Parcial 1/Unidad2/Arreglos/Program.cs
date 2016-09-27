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
                        Console.WriteLine("");
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
                        Console.WriteLine("Se calculará la cantidad de ceros del siguiente arreglo");
                        Console.WriteLine("{0,2,5,7,6}");
                        Console.WriteLine("{0,0,0,3,8}");
                        Console.WriteLine("{2,9,6,3,4}");
                        Console.WriteLine("{1,5,6,1,4}");
                        Console.WriteLine("{0,9,2,5,0}");
                        Console.WriteLine("");
                        Console.WriteLine("La cantidad de ceros es: "+Ejercicio1().ToString());
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    goto case 0;
                case 2:
                    {
                        
                        Console.WriteLine("");
                    }
                    goto case 0;
                case 3:
                    {
                        Console.WriteLine("Suma de Matrices 2x2");
                        Ejercicio3();
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    goto case 0;
                case 4:
                    {
                        Ejercicio4();
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    goto case 0;
                case 5:
                    {
                        Ejercicio5();
                        Console.WriteLine("");
                        Console.ReadLine();
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

        static int Ejercicio1()
        {
            int cantidadCeros = 0, longitud = 5;
            int[,] Arreglo = new int[,] {
                {0,2,5,7,6},
                {0,0,0,3,8},
                {2,9,6,3,4},
                {1,5,6,1,4},
                {0,9,2,5,0}
            };
            for (int i = 0; i < longitud;i ++)
            {
                for (int e = 0; e < longitud; e++)
                {
                    if (Arreglo[i,e] == 0)
                    {
                        cantidadCeros++;
                    }
                }
            }
            return cantidadCeros;
        }

        static void Ejercicio3()
        {
            Console.WriteLine("");
            double[,] Matriz1 = new double[2, 2],
                   Matriz2 = new double[2, 2];
            for (int a = 0; a < 2; a++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (a == 0)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("Ingrese el valor {0} de la matriz uno", j + 1 + i);
                                double valor = Convert.ToDouble(Console.ReadLine());
                                Matriz1[i, j] = valor;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el valor {0} de la matriz uno", j + 2 + i);
                                double valor = Convert.ToDouble(Console.ReadLine());
                                Matriz1[i, j] = valor;
                            }
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("Ingrese el valor {0} de la matriz dos", j + 1 + i);
                                int valor = Convert.ToInt32(Console.ReadLine());
                                Matriz2[i, j] = valor;
                            }
                            else
                            {
                                Console.WriteLine("Ingrese el valor {0} de la matriz dos", j + 2 + i);
                                int valor = Convert.ToInt32(Console.ReadLine());
                                Matriz2[i, j] = valor;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Las matrices son:");
            Console.WriteLine("{ " + Matriz1[0, 0] + " , " + Matriz1[0, 1] + " }    { " + Matriz2[0, 0] + " , " + Matriz2[0, 1] + " }");
            Console.WriteLine("{ " + Matriz1[1, 0] + " , " + Matriz1[1, 1] + " }    { " + Matriz2[1, 0] + " , " + Matriz2[1, 1] + " }");
            Console.WriteLine("");
            Console.WriteLine("Suma:");
            MostrarArreglo2x2(Eje3Suma(Matriz1, Matriz2));
            Console.WriteLine("Resta:");
            MostrarArreglo2x2(Eje3Resta(Matriz1, Matriz2));
            Console.WriteLine("Multiplicación:");
            MostrarArreglo2x2(Eje3Multiplicacion(Matriz1, Matriz2));
            Console.WriteLine("División:");
            MostrarArreglo2x2(Eje3Division(Matriz1, Matriz2));

        }

        static double[,] Eje3Suma(double[,] matriz1, double[,] matriz2)
        {
            double[,] suma = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return suma;
        }
        static double[,] Eje3Resta(double[,] matriz1, double[,] matriz2)
        {
            double[,] resta = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resta[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }
            return resta;
        }
        static double[,] Eje3Multiplicacion(double[,] matriz1, double[,] matriz2)
        {
            double[,] mult = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mult[i, j] = matriz1[i, j] * matriz2[i, j];
                }
            }
            return mult;
        }
        static double[,] Eje3Division(double[,] matriz1, double[,] matriz2)
        {
            double[,] div = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    div[i, j] = matriz1[i, j] / matriz2[i, j];
                }
            }
            return div;
        }
        static void MostrarArreglo2x2(double[,] arreglo)
        {
            Console.WriteLine("{ " + arreglo[0, 0] + " , " + arreglo[0, 1] + " }");
            Console.WriteLine("{ " + arreglo[1, 0] + " , " + arreglo[1, 1] + " }");
            Console.WriteLine("");
        }
        static void MostrarArregloInt(int[,] arreglo, int tamaño)
        {
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < tamaño; j++)
                {
                    if (j == tamaño - 1)
                    {
                        Console.Write(arreglo[i, j] + "");
                    }
                    else
                    {
                        Console.Write(arreglo[i, j] + ", ");
                    }
                }
                Console.Write(" }");
                Console.WriteLine("");
            }
        }
        static void MostrarArregloInt(int[,] arreglo, int columnas, int filas)
        {
            Console.WriteLine("                                           |Suma|Prom.|");
            Console.WriteLine("-----------------------------------------  ------------");
            for (int i = 0; i < filas; i++)
            {
                double prom = 0, suma = 0 ;
                Console.Write("| ");
                for (int j = 0; j < columnas; j++)
                {
                    suma += arreglo[i, j];
                    if (j == columnas - 1)
                    {
                        prom = suma / 10;
                        Console.Write(arreglo[i, j] + "");

                    }
                    else
                    {
                        Console.Write(arreglo[i, j] + " | ");
                    }
                }
                Console.WriteLine(" |  | " + suma + " | " + prom + " |");
                Console.WriteLine("-----------------------------------------  ------------");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            double[] sum = new double[10];
            for (int i = 0; i < columnas; i++)
            {
                int cont = 0;
                for (cont = 0; cont < filas; cont++)
                {
                    sum[i] += arreglo[cont, i];
                }
            }
            Console.Write("| ");
            for (int j = 0; j < columnas; j++)
            {
                if (j == columnas - 1)
                {
                    Console.Write(sum[j] + "|");

                }
                else
                {
                    Console.Write(sum[j] + "| ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");
            double prome = 0;
            for (int j = 0; j < columnas; j++)
            {
                prome = sum[j] / 5;
                if (prome.ToString().Length == 1)
                {
                    Console.Write("|  "+prome);
                }
                else
                {
                    if (j == columnas - 1)
                    {
                        Console.Write("|"+prome + "|");

                    }
                    else
                    {
                        Console.Write("|"+prome);
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------");

        }
        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese el tamaño del arreglo (cuadrado)");
            int tam = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[tam, tam];
            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    if (j == i)
                    {
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }
            MostrarArregloInt(matriz, tam);

        }

        static void Ejercicio5()
        {
            Random RdmValor = new Random();
            int[,] arreglo = new int[5, 10];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {   
                    try
                    {
                        if (arreglo[i, j - 1] == RdmValor.Next(1, 10))
                        {
                            arreglo[i, j] = RdmValor.Next(1, 10);
                        }
                        else
                        {
                            arreglo[i, j] = RdmValor.Next(1, 10);
                        }
                    }
                    catch
                    {
                        arreglo[i, j] = RdmValor.Next(1, 10);
                    }
                }
            }
            MostrarArregloInt(arreglo, 10, 5);

        }
    }
}
