using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            int[,] Numeros = new int[,]
            {
                { 1,2,3 },
                { 5,6,7 },
                { 10,1,2 }
            };
            int longitud = 3;
            int sumaColumna = 0;
            int sumaFila = 0;
            int diagonalPrincipal = 0;
            int diagonalInversa = 0;
            for (int i = 0; i < longitud; i++) // Columnas
            {
                for (int j = 0; j < longitud; j++) // Filas
                {
                    if (i == 0)
                    {
                        sumaColumna += Numeros[j, i];
                    }
                    if (j == 0)
                    {
                        sumaFila += Numeros[j, i];
                    }
                    if (j == i)
                    {
                        diagonalPrincipal += Numeros[j, i];
                    }
                    if (i+j == longitud-1)
                    {
                        diagonalInversa += Numeros[j, i];
                    }
                }
            }
            MessageBox.Show("Suma columna: " + sumaColumna);
            MessageBox.Show("Suma fila: " + sumaFila);
            MessageBox.Show("Suma diagonal principal: " + diagonalPrincipal);
            MessageBox.Show("Suma diagonal inversa: " + diagonalInversa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Forma 1 - arreglos paralelos (multidimensional)
            String[,] Colores = new String[,]
        {
            { "rojo","Azul","Verde" },
            { "rojo","Azul","Verde" },
            { "rojo","Azul","Verde" }
        };

            String[,] IndiceColores = new String[,]
            {
            { "a","s","r" },
            { "t","f","g" },
            { "h","i","j" }
            };

            for (int i = 0; i< 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    MessageBox.Show("Color = "+ Colores[i,j]);
                    MessageBox.Show("Índice = " + IndiceColores[i, j]);
                }
            }



            // Forma 2 - arreglos paralelos (unidimencional o vectores)
            String[] ColoresUnidimencional = new String[]
            {
            "rojo","Azul","Verde",
            "rojo","Azul","Verde",
            "rojo","Azul","Verde"
            };

            String[] IndiceColoresUnidimencional = new String[]
            {
             "a","s","r" ,
             "t","f","g" ,
             "h","i","j" 
            };

            // Leer Vector Colores
            for (int color = 0; color < IndiceColores.Length; color++)
            {
                MessageBox.Show("" + ColoresUnidimencional[color]);
            }

            // Leer Vector Índice
            for (int indicecolor = 0; indicecolor < IndiceColores.Length; indicecolor++)
            {
                MessageBox.Show("" + IndiceColoresUnidimencional[indicecolor]);
            }

            // Forma 3 - Usando una clase y objetos para mostrar un array de objetos

            // Arreglo unidimencional de color
            Ejemplos.Color[] ArregloColores =
            {
                new Ejemplos.Color {indice = "a", Valor="rojo" },
                new Ejemplos.Color {indice = "s", Valor="Azul" },
                new Ejemplos.Color {indice = "r", Valor="Verde" },
                new Ejemplos.Color {indice = "t", Valor="rojo" },
                new Ejemplos.Color {indice = "f", Valor="Azul" },
                new Ejemplos.Color {indice = "g", Valor="Verde" },
                new Ejemplos.Color {indice = "h", Valor="rojo" },
                new Ejemplos.Color {indice = "i", Valor="Azul" },
                new Ejemplos.Color {indice = "j", Valor="Verde" },
            };

            int cont = 0;
            string indice = "";
            // Lectura arreglo de objetos

            foreach (Ejemplos.Color ColorActual in ArregloColores)
            {
                MessageBox.Show("Índice = " + ColorActual.indice);
                MessageBox.Show("Valor = " + ColorActual.Valor);

               /* if( si hay ColorActual.Valor ¿En dónde ó existe en donde?){
                * // Aumentar ¿Qué? y guardar ColorActual.indice ¿En dónde?
                * } else{
                * Agregar a ¿Dónde? para generar otra validación de existencia
                * }*/

                if (ColorActual.Valor == ArregloColores[cont].Valor)
                {
                    indice += ColorActual.Valor + " tiene como índices: " + ColorActual.indice + "\n";
                }
                cont++;
            }

            MessageBox.Show(indice);

            // Mostrar y agrupar índices tomando en cuenta el valor de cada índice
            // Ejemplo: rojo Tiene "a", "t", "h"



        }
    }
}
