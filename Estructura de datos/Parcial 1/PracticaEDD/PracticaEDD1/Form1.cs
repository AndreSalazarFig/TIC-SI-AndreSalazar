using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaEDD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formula oFurmula = new Formula(Convert.ToDouble(txtA.Text.Trim()), Convert.ToDouble(txtB.Text.Trim()), Convert.ToDouble(txtC.Text.Trim()));
            label5.Text = oFurmula.ResultadoX().ToString();
            label6.Text = oFurmula.ResultadoY().ToString();
            label5.Visible = true;
            label6.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
        }
    }
}
