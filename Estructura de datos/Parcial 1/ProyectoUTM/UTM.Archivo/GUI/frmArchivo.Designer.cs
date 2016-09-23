namespace UTM.SI.GUI
{
    partial class frmArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.lblTraer = new System.Windows.Forms.Button();
            this.txtParcial2 = new System.Windows.Forms.TextBox();
            this.txtParcial3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(0, 0);
            this.txtDatos.Multiline = true;
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(597, 136);
            this.txtDatos.TabIndex = 0;
            // 
            // lblTraer
            // 
            this.lblTraer.Location = new System.Drawing.Point(603, 4);
            this.lblTraer.Name = "lblTraer";
            this.lblTraer.Size = new System.Drawing.Size(75, 46);
            this.lblTraer.TabIndex = 1;
            this.lblTraer.Text = "Traer";
            this.lblTraer.UseVisualStyleBackColor = true;
            this.lblTraer.Click += new System.EventHandler(this.txtTraer_Click);
            // 
            // txtParcial2
            // 
            this.txtParcial2.Location = new System.Drawing.Point(0, 158);
            this.txtParcial2.Multiline = true;
            this.txtParcial2.Name = "txtParcial2";
            this.txtParcial2.Size = new System.Drawing.Size(597, 147);
            this.txtParcial2.TabIndex = 2;
            // 
            // txtParcial3
            // 
            this.txtParcial3.Location = new System.Drawing.Point(0, 324);
            this.txtParcial3.Multiline = true;
            this.txtParcial3.Name = "txtParcial3";
            this.txtParcial3.Size = new System.Drawing.Size(597, 151);
            this.txtParcial3.TabIndex = 3;
            // 
            // frmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 472);
            this.Controls.Add(this.txtParcial3);
            this.Controls.Add(this.txtParcial2);
            this.Controls.Add(this.lblTraer);
            this.Controls.Add(this.txtDatos);
            this.Name = "frmArchivo";
            this.Text = "frmArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button lblTraer;
        private System.Windows.Forms.TextBox txtParcial2;
        private System.Windows.Forms.TextBox txtParcial3;
    }
}