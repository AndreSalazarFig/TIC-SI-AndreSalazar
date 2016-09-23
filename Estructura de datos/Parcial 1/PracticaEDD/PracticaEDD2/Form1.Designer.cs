namespace PracticaEDD2
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
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.txtMultiplicacion = new System.Windows.Forms.TextBox();
            this.txtIgual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(30, 36);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(66, 20);
            this.txtValorA.TabIndex = 0;
            this.txtValorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(29, 72);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(67, 20);
            this.txtValorB.TabIndex = 2;
            this.txtValorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 48);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Multiplicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "¿Es Igual?";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(159, 25);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.ReadOnly = true;
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 8;
            // 
            // txtMultiplicacion
            // 
            this.txtMultiplicacion.Location = new System.Drawing.Point(159, 80);
            this.txtMultiplicacion.Name = "txtMultiplicacion";
            this.txtMultiplicacion.ReadOnly = true;
            this.txtMultiplicacion.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplicacion.TabIndex = 9;
            // 
            // txtIgual
            // 
            this.txtIgual.Location = new System.Drawing.Point(159, 135);
            this.txtIgual.Name = "txtIgual";
            this.txtIgual.ReadOnly = true;
            this.txtIgual.Size = new System.Drawing.Size(100, 20);
            this.txtIgual.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "R1 = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "R2 = ";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(52, 188);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(13, 13);
            this.lblR1.TabIndex = 13;
            this.lblR1.Text = "0";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(52, 216);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(13, 13);
            this.lblR2.TabIndex = 14;
            this.lblR2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 238);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIgual);
            this.Controls.Add(this.txtMultiplicacion);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.txtValorA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.TextBox txtMultiplicacion;
        private System.Windows.Forms.TextBox txtIgual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblR2;
    }
}

