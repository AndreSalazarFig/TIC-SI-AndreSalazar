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
    }
}
