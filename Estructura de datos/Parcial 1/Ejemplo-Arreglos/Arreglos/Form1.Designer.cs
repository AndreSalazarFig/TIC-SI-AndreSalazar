namespace Arreglos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.Location = new System.Drawing.Point(108, 95);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(489, 204);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Botonzote";
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 418);
            this.Controls.Add(this.btnBoton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
    }
}

