using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo oCirculo = new Circulo(Convert.ToDouble(txtRadio.Text.Trim()));
            label4.Text = oCirculo.Area().ToString();
            label5.Text = oCirculo.Perimetro().ToString();
            label4.Visible = true;
            label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rectangulo oRectangulo = new Rectangulo(Convert.ToDouble(txtBase.Text.Trim()), Convert.ToDouble(txtAltura.Text.Trim()));
            label10.Text = oRectangulo.Area().ToString();
            label11.Text = oRectangulo.Perimetro().ToString();
            label10.Visible = true;
            label11.Visible = true;
        }
    }
}
