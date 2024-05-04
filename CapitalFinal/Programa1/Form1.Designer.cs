namespace Programa1
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtAcumulados = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(7, 29);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(132, 22);
            this.txtMonto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto Inicial";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(7, 75);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(132, 22);
            this.txtInteres.TabIndex = 2;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(7, 136);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(132, 22);
            this.txtPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasa interes Anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Periodo de tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capital Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Intereses acumulados";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(370, 214);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(132, 22);
            this.txtCapital.TabIndex = 8;
            // 
            // txtAcumulados
            // 
            this.txtAcumulados.Location = new System.Drawing.Point(201, 214);
            this.txtAcumulados.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcumulados.Name = "txtAcumulados";
            this.txtAcumulados.Size = new System.Drawing.Size(132, 22);
            this.txtAcumulados.TabIndex = 9;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(7, 183);
            this.btncalc.Margin = new System.Windows.Forms.Padding(4);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(158, 77);
            this.btncalc.TabIndex = 10;
            this.btncalc.Text = "Calcular";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtAcumulados);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Programa 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtAcumulados;
        private System.Windows.Forms.Button btncalc;
    }
}

