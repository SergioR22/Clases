namespace Clase26032018
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botondivi = new System.Windows.Forms.Button();
            this.butonmulti = new System.Windows.Forms.Button();
            this.butonresta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelValB = new System.Windows.Forms.Label();
            this.LabelValA = new System.Windows.Forms.Label();
            this.BotonCalcular = new System.Windows.Forms.Button();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textboxA = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botondivi);
            this.groupBox1.Controls.Add(this.butonmulti);
            this.groupBox1.Controls.Add(this.butonresta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LabelValB);
            this.groupBox1.Controls.Add(this.LabelValA);
            this.groupBox1.Controls.Add(this.BotonCalcular);
            this.groupBox1.Controls.Add(this.textbox2);
            this.groupBox1.Controls.Add(this.textboxA);
            this.groupBox1.Location = new System.Drawing.Point(41, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // botondivi
            // 
            this.botondivi.Location = new System.Drawing.Point(152, 141);
            this.botondivi.Name = "botondivi";
            this.botondivi.Size = new System.Drawing.Size(39, 23);
            this.botondivi.TabIndex = 8;
            this.botondivi.Text = "/";
            this.botondivi.UseVisualStyleBackColor = true;
            this.botondivi.Click += new System.EventHandler(this.botondivi_Click);
            // 
            // butonmulti
            // 
            this.butonmulti.Location = new System.Drawing.Point(104, 141);
            this.butonmulti.Name = "butonmulti";
            this.butonmulti.Size = new System.Drawing.Size(39, 23);
            this.butonmulti.TabIndex = 7;
            this.butonmulti.Text = "*";
            this.butonmulti.UseVisualStyleBackColor = true;
            this.butonmulti.Click += new System.EventHandler(this.butonmulti_Click);
            // 
            // butonresta
            // 
            this.butonresta.Location = new System.Drawing.Point(56, 141);
            this.butonresta.Name = "butonresta";
            this.butonresta.Size = new System.Drawing.Size(39, 23);
            this.butonresta.TabIndex = 6;
            this.butonresta.Text = "-";
            this.butonresta.UseVisualStyleBackColor = true;
            this.butonresta.Click += new System.EventHandler(this.butonresta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // LabelValB
            // 
            this.LabelValB.AutoSize = true;
            this.LabelValB.Location = new System.Drawing.Point(33, 79);
            this.LabelValB.Name = "LabelValB";
            this.LabelValB.Size = new System.Drawing.Size(40, 13);
            this.LabelValB.TabIndex = 4;
            this.LabelValB.Text = "Valor 2";
            // 
            // LabelValA
            // 
            this.LabelValA.AutoSize = true;
            this.LabelValA.Location = new System.Drawing.Point(33, 52);
            this.LabelValA.Name = "LabelValA";
            this.LabelValA.Size = new System.Drawing.Size(40, 13);
            this.LabelValA.TabIndex = 3;
            this.LabelValA.Text = "Valor 1";
            // 
            // BotonCalcular
            // 
            this.BotonCalcular.Location = new System.Drawing.Point(6, 141);
            this.BotonCalcular.Name = "BotonCalcular";
            this.BotonCalcular.Size = new System.Drawing.Size(39, 23);
            this.BotonCalcular.TabIndex = 2;
            this.BotonCalcular.Text = "+";
            this.BotonCalcular.UseVisualStyleBackColor = true;
            this.BotonCalcular.Click += new System.EventHandler(this.BotonCalcular_Click);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(85, 72);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(100, 20);
            this.textbox2.TabIndex = 1;
            // 
            // textboxA
            // 
            this.textboxA.Location = new System.Drawing.Point(85, 46);
            this.textboxA.Name = "textboxA";
            this.textboxA.Size = new System.Drawing.Size(100, 20);
            this.textboxA.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SergioR22";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelValB;
        private System.Windows.Forms.Label LabelValA;
        private System.Windows.Forms.Button BotonCalcular;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textboxA;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button botondivi;
        private System.Windows.Forms.Button butonmulti;
        private System.Windows.Forms.Button butonresta;
    }
}

