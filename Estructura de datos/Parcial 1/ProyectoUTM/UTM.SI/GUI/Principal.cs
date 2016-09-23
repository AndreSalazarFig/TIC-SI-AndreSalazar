using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UTM.SI.GUI
{
    public partial class Principal : Form
    {
        

        public Principal()
        {
            InitializeComponent();
            CargaMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void CargaMenuArchivo()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("Archivos");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "Archivos")
                {
                    frmArchivo ofrmArchivo = new frmArchivo();
                    showwindow(ofrmArchivo);                 
                }          

            };
            nbbArchivo.RelatedControl = treeView;     
        }
        public void CargaMenuXml()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("XML");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "XML")
                {
                    //UTM.XML.GUI.frmXML ofrmXML = new UTM.XML.GUI.frmXML();
                    //showwindow(ofrmXML);
                }

            };
            nbbXML.RelatedControl = treeView;   
        }
        public void CargaMenuSqlite()
        {
            TreeView treeView = new TreeView();
            TreeNode treeNode = new TreeNode("SQLite");
            treeView.Nodes.Add(treeNode);
            treeView.NodeMouseClick += delegate(object sender, TreeNodeMouseClickEventArgs e)
            {
                TreeNode clickedNode = e.Node;
                if (clickedNode.Text == "SQLite")
                {
                    //UTM.SQLite.GUI.frmSQLite ofrmSQLite = new UTM.SQLite.GUI.frmSQLite();
                    //showwindow(ofrmSQLite);
                }

            };
            nbbSQLite.RelatedControl = treeView;     
        }
        public void CargaMenu() 
        {
            CargaMenuArchivo();
            CargaMenuXml();
            CargaMenuSqlite();
        }
        private void showwindow(Form ventanaMostrar)
        {
            bool found = false;
            Form[] charr = this.MdiChildren;
            if (charr.Length == 0)
            {
                ventanaMostrar.MdiParent = this;
                ventanaMostrar.Show();
                ventanaMostrar.WindowState = FormWindowState.Maximized;
            }
            else
            {
                foreach (Form chform in charr)
                {
                    if ((chform.Text) == (ventanaMostrar.Text))
                    {
                        chform.Activate();
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (found == false)
                {
                    ventanaMostrar.MdiParent = this;
                    ventanaMostrar.Show();
                    ventanaMostrar.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
