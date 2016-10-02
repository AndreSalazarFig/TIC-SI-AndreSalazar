using System;
using System.Collections;
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
                        Console.WriteLine("8. Limpiar pantalla");
                        Console.WriteLine("9. Salir");
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
                        if (opcion == 8) { goto case 8; }
                        if (opcion == 9) { goto case 9; }
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
                        Ejercicio2();
                        Console.WriteLine("");
                        Console.ReadLine();
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
                        Ejercicio6();
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    goto case 0;
                case 7:
                    {
                        Ejercicio7();
                        Console.WriteLine("");
                        Console.ReadLine();
                    }
                    goto case 0;
                case 8:
                    {
                        Console.Clear();
                    }
                    goto case 0;
                case 9:
                    {

                    }
                    break;
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

        static void Ejercicio2()
        {
            Console.WriteLine("Seleccione una opción");
            Console.WriteLine("");
            Console.WriteLine("1. Crear una matríz");
            Console.WriteLine("2. Mostrar una matríz predefinida");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    {
                        int[,] matriz = new int[2, 2];
                        for (int i = 0; i < 2; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                if (i == 0)
                                {
                                    Console.WriteLine("Ingrese el valor {0} de la matríz", j + 1 + i);
                                    int valor = Convert.ToInt32(Console.ReadLine());
                                    matriz[i, j] = valor;
                                }
                                else
                                {
                                    if (i == 1)
                                    {
                                        Console.WriteLine("Ingrese el valor {0} de la matríz", j + 3 + i);
                                        int valor = Convert.ToInt32(Console.ReadLine());
                                        matriz[i, j] = valor;
                                    }
                                    else
                                    {
                                        if (i == 2)
                                        {
                                            Console.WriteLine("Ingrese el valor {0} de la matríz", j + 5 + i);
                                            int valor = Convert.ToInt32(Console.ReadLine());
                                            matriz[i, j] = valor;
                                        }
                                    }
                                }
                            }
                        }
                        MostrarArregloEje2(matriz);




                    }
                    break;
                case 2:
                    {
                        int[,] matriz = new int[,] { { 4, 9, 2 }, { 3, 5, 7 }, { 8, 1, 6 } };
                        MostrarArregloEje2(matriz);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("No ha seleccionado una opción válida, se cerrará el ejercicio");
                    }
                    break;
            }
            
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
        static void MostrarArreglo12x5(int[,] arreglo, int filas, int columnas)
        {
            Console.WriteLine("--------------------------");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < columnas; j++)
                {
                    if (j == columnas - 1)
                    {
                        if (arreglo[i, j].ToString().Length == 1)
                        {
                            Console.WriteLine(arreglo[i, j] + "  |");
                        }
                        else
                        {
                            Console.WriteLine(arreglo[i, j] + " |");
                        }
                    }
                    else
                    {
                        if (arreglo[i, j].ToString().Length == 1)
                        {
                            Console.Write(arreglo[i, j] + "  | ");
                        }
                        else
                        {
                            Console.Write(arreglo[i, j] + " | ");
                        }
                        
                    }
                }
                Console.WriteLine("--------------------------");
            }
        }

        static void MostrarArreglo12x5(double[,] arreglo, int filas, int columnas)
        {
            Console.WriteLine("-----------------");
            for (int i = 0; i < filas; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < columnas; j++)
                {
                    if (j == columnas - 1)
                    {
                        if (arreglo[i, j].ToString().Length == 2)
                        {
                            Console.WriteLine(arreglo[i, j] + " |");
                        }
                        else
                        {
                            Console.WriteLine(arreglo[i, j] + " |");
                        }
                    }
                    else
                    {
                        if (arreglo[i, j].ToString().Length == 2)
                        {
                            Console.Write(arreglo[i, j] + " | ");
                        }
                        else
                        {
                            Console.Write(arreglo[i, j] + " | ");
                        }

                    }
                }
                Console.WriteLine("-----------------");
            }
        }
        static void MostrarArregloEje2(int[,] matriz)
        {
            int filas = 2, columnas = 2, iguales = 0, valor = 0 ;
            Console.WriteLine("-------------");
            for (int i = 0; i < filas; i++)
            {
                int suma = 0;
                Console.Write("| ");
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                    if (j == columnas - 1)
                    {
                        Console.Write(matriz[i, j] + "");

                    }
                    else
                    {
                        Console.Write(matriz[i, j] + " | ");
                    }
                }
                if (i == 0)
                {
                    valor = suma;
                    iguales = 1;
                }
                else
                {
                    if (suma == valor)
                    {
                        iguales++;
                    }
                }
                Console.WriteLine(" |  | " + suma + " |");
                Console.WriteLine("-------------");
            }
            Console.WriteLine("");
            double[] sum = new double[3];
            for (int i = 0; i < columnas; i++)
            {
                int cont = 0;
                for (cont = 0; cont < filas; cont++)
                {
                    sum[i] += matriz[cont, i];
                }
            }
            Console.WriteLine("-------------");
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
                if (sum[j] == valor)
                {
                    iguales++;
                }
            }
            int dp = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
            Console.Write("  | " + (dp) + " |");
            Console.WriteLine("");
            Console.WriteLine("-------------");
            if (dp == valor)
            {
                iguales++;
            }
            if (iguales == 7)
            {
                Console.WriteLine("La constante mágica es: " + valor);
            }
            else
            {
                Console.WriteLine("La matríz no tiene constante mágica ");
            }
        }
        static string ValidarDía(int dia)
        {
            string d = "";
            if (dia == 0)
            {
                d = "Lunes";
            }
            if (dia == 1)
            {
                d = "Martes";
            }
            if (dia == 2)
            {
                d = "Miércoles";
            }
            if (dia == 3)
            {
                d = "Jueves";
            }
            if (dia == 4)
            {
                d = "Viernes";
            }
            return d;
        }
        static string ValidarMes(int mes)
        {
            string m = "";
            if (mes == 0)
            {
                m = "Enero";
            }
            if (mes == 1)
            {
                m = "Febrero";
            }
            if (mes == 2)
            {
                m = "Marzo";
            }
            if (mes == 3)
            {
                m = "Abril";
            }
            if (mes == 4)
            {
                m = "Mayo";
            }
            if (mes == 5)
            {
                m = "Junio";
            }
            if (mes == 6)
            {
                m = "Julio";
            }
            if (mes == 7)
            {
                m = "Agosto";
            }
            if (mes == 8)
            {
                m = "Septiembre";
            }
            if (mes == 9)
            {
                m = "Octubre";
            }
            if (mes == 10)
            {
                m = "Noviembre";
            }
            if (mes == 11)
            {
                m = "Diciembre";
            }
            return m;
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

        static void Ejercicio6()
        {
            int[,] matriz = new int[,] {
                { 1 , 16 , 10 , 12 , 24 },
                { 40 , 55 , 10 , 11 , 18 },
                { 15 , 41 , 78 , 14 , 51  },
                { 35 , 22 , 81 , 15 , 12 },
                { 50 , 12 , 71 , 10 , 20 },
                { 70 , 40 , 60 , 28 , 22  },
                { 50 , 50 , 50 , 36 , 25 },
                { 40 , 70 , 40 , 11 , 20 },
                { 20 , 20 , 30 , 12 , 18  },
                { 10 , 40 , 32 , 13 , 16 },
                { 50 , 3 , 24 , 15 , 82 },
                { 40 , 46 , 15 , 46 , 22  }
            };
            MostrarArreglo12x5(matriz, 12, 5);
            string diaMe = "", mesMe = "", diaMa = "", mesMa = "";
            int menor = 0, mayor = 0, ventaTotal = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 && j == 0) { menor = matriz[i, j]; mayor = menor; diaMa = ValidarDía(j); mesMa = ValidarMes(i); diaMe = ValidarDía(j); mesMe = ValidarMes(i); }
                    if (matriz[i,j] > mayor) { mayor = matriz[i, j]; diaMa = ValidarDía(j); mesMa = ValidarMes(i); }
                    if (matriz[i, j] < menor) { menor = matriz[i, j]; diaMe = ValidarDía(j); mesMe = ValidarMes(i); }
                    ventaTotal += matriz[i, j];
                }
            }
            double[] sum = new double[5];
            for (int i = 0; i < 5; i++)
            {
                for (int cont = 0; cont < 12; cont++)
                {
                    sum[i] += matriz[cont, i];
                }
            }
            Console.WriteLine("La menor venta es de ${0} el día {1} del mes {2}", menor, diaMe, mesMe);
            Console.WriteLine("La mayor venta es de ${0} el día {1} del mes {2}", mayor, diaMa, mesMa);
            Console.WriteLine("La venta total es de ${0}", ventaTotal);

        }

        static void Ejercicio7()
        {
            double[,] matriz = new double[,] {
                { 5.5 , 8.6 , 10 },
                { 8.0 , 5.5 , 10 },
                { 9.0 , 4.1 , 7.8 },
                { 10 , 2.2 , 8.1 },
                { 7.0 , 1.2 , 7.1 },
                { 9.0 , 4.0 , 6.0 },
                { 6.5 , 5.0 , 5.0 },
                { 4.0 , 7.0 , 4.0 },
                { 8.0 , 8.0 , 9.0 },
                { 10 , 9.0 , 9.2 },
                { 5.0 , 10 , 8.4 },
                { 9.0 , 4.6 , 7.5 }
            };
            MostrarArreglo12x5(matriz, 12, 3);
            int sum = 0;
            double mayor = 0, menor = 0;
            int flag = 0;
            int x = 0, x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0;
            double[] arregloA = { 5.5, 8.0, 9.0, 10, 7.0, 9.0, 6.5, 4.0, 8.0, 10, 5.0, 9.0 };
            double[] arregloB = { 8.6, 5.5, 4.1, 2.2, 9.2, 4.0, 5.0, 7.0, 8.0, 9.0, 10, 4.6 };
            double[] arregloC = { 10, 10, 7.8, 8.1, 7.1, 6.0, 5.0, 4.0, 9.0, 9.2, 8.4, 7.5 };

            IEnumerator A = arregloA.GetEnumerator();
            IEnumerator B = arregloB.GetEnumerator();
            IEnumerator C = arregloC.GetEnumerator();
            int fila = 0;
            while (A.MoveNext() && B.MoveNext() && C.MoveNext())
            {
                fila++;

                double prom = (double)A.Current;
                prom += (double)B.Current;
                prom += (double)C.Current;
                prom /= 3.0;


                if (prom < 7.0)
                {

                    sum = sum + 1;
                }

                if (flag == 0)
                {
                    mayor = prom;
                    menor = prom;
                    flag = 1;
                }
                else
                {
                    if (prom > mayor)
                        mayor = prom;
                    if (prom < menor)
                        menor = prom;
                }

                if (prom <= 4.9)
                {
                    x = x + 1;
                }
                if (prom >= 5.0 && prom <= 5.9)
                {
                    x1 = x1 + 1;
                }
                if (prom >= 6.0 && prom <= 6.99)
                {
                    x2 = x2 + 1;
                }
                if (prom >= 7.0 && prom <= 7.9)
                {
                    x3 = x3 + 1;
                }
                if (prom >= 8.0 && prom <= 8.9)
                {
                    x4 = x4 + 1;
                }
                if (prom >= 9.0 && prom <= 10)
                {
                    x5 = x5 + 1;
                }

                Console.WriteLine("Promedio de la fila {0}: {1}", fila , prom);
                
            }

            Console.WriteLine("\nAlumnos Reprobados: " + sum);
            Console.Write("El Menor Promedio es " + menor);
            Console.Write("\nEl Mayor Promedio es " + mayor);
            Console.WriteLine("");
            Console.Write("\nCantidad de alumnos por promedios");
            Console.Write("\n5.0 – 5.9: " + x1);
            Console.Write("\n6.0 – 6.9: " + x2);
            Console.Write("\n7.0 – 7.9: " + x3);
            Console.Write("\n8.0 – 8.9: " + x4);
            Console.Write("\n9.0 – 10 : " + x5);
        }


    }
}
