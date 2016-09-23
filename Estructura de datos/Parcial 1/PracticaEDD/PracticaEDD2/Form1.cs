using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEDD2
{
    public partial class Form1 : Form
    {
        Ejercicio oEjercicio = new Ejercicio();
        double a;
        double b;
        double r1;
        double r2;
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(txtValorA.Text);
                if (Convert.ToDouble(txtValorB.Text) != 0)
                {
                    b = Convert.ToDouble(txtValorB.Text);
                    if (i == 2)
                    {
                        r2 = oEjercicio.CrearRacional(a, b);
                        lblR2.Text = r2.ToString();
                        btnCalcular.Enabled = false;
                        Calcular();
                    }
                    if (i == 1)
                    {
                        r1 = oEjercicio.CrearRacional(a, b);
                        lblR1.Text = r1.ToString();
                        i = 2;
                        Limpiar();
                    }
                    
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error: " + a);
            }
            
        }

        private void Limpiar()
        {
            txtValorA.Focus();
            txtValorA.Clear();
            txtValorB.Clear();
        }

        private void Calcular()
        {
            txtSuma.Text = RegresarConversion(oEjercicio.Suma(r1, r2));
            //txtSuma.Text = oEjercicio.Suma(r1, r2).ToString();
            txtMultiplicacion.Text = RegresarConversion(oEjercicio.Multiplicar(r1, r2));
            if (oEjercicio.EsIgual(r1, r2) == true)
            {
                txtIgual.Text = "Si";
            }
            else { txtIgual.Text = "No"; }
        }

        private string RegresarConversion(double a)
        {
            int error = 0;
            int con = 0;
            int enteros = 0;
            int dec = 0;
            string cadena;
            cadena = a.ToString();
            for (int i = 0; i < cadena.Length; i++)
            {
                if(Convert.ToChar(cadena[i]) ==',')
                {
                    enteros = Convert.ToInt32(cadena.Substring(0,i));
                    error++;
                    con = i + 1;
                    i = cadena.Length;
                }
            }
            string t = Convert.ToString(cadena.Substring(con, cadena.Length - con));
            dec = Convert.ToInt32(cadena.Substring(con, cadena.Length-con));
            if (enteros == 0)
            {
                try
                {
                    if (Convert.ToString(cadena.Substring(con, cadena.Length - con)).Substring(0, 2) == "00")
                    {
                        cadena = dec + "/1000";
                        return cadena;
                    }
                }
                catch { }
                try
                {
                    if (Convert.ToString(cadena.Substring(con, cadena.Length - con)).Substring(0, 1) == "0")
                    {
                        cadena = dec + "/100";
                        return cadena;
                    }
                }
                catch { }
                cadena = dec+"/10";
                return cadena;
            }
            cadena = (enteros * dec)+"/"+dec;
            return cadena;
        }

    }
}
