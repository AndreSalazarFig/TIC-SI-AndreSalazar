using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace UTM.SI.GUI
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }

        private void txtTraer_Click(object sender, EventArgs e)
        {
            LeerArchivo();
        }
        public void LeerArchivo()
        {
            string rutaCompleta = Application.StartupPath.ToString();
            string ruta = rutaCompleta.Substring(0, rutaCompleta.Length - 16) + @"UTM.Archivo\bin\FExamen.txt";
            StreamReader objReader = new StreamReader(ruta, System.Text.Encoding.Default);
            string leelinea;
            ArrayList contenido = new ArrayList();
            ArrayList parcial2 = new ArrayList();
            ArrayList parcial3 = new ArrayList();
            while (objReader.Peek() > -1)
            {
                leelinea = objReader.ReadLine();
                if(leelinea == "Parcial 2")
                {
                    while (objReader.Peek() > -1)
                    {
                        if (leelinea == "Parcial 3")
                        {
                            parcial3.Add(leelinea);
                            leelinea = objReader.ReadToEnd();
                            parcial3.Add(leelinea);
                        }
                        else
                        {
                            if (leelinea == "Parcial 3")
                            {
                                break;
                            }
                            parcial2.Add(leelinea);
                            leelinea = objReader.ReadLine();
                        }
                    }
                }
                else
                {
                    contenido.Add(leelinea);
                }
            }
            objReader.Close();
            foreach (string datos in contenido)
                txtDatos.Text += datos.ToString() + Environment.NewLine;
            foreach (string datos in parcial2)
                txtParcial2.Text += datos.ToString() + Environment.NewLine;
            foreach (string datos in parcial3)
                txtParcial3.Text += datos.ToString() + Environment.NewLine;
        }
    }
}
