namespace proyeccalculadoraseba
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
            this.CajaResultado = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnResta = new System.Windows.Forms.Button();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.BtnResultado = new System.Windows.Forms.Button();
            this.BtnPunto = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnMultiplicacion = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CajaResultado
            // 
            this.CajaResultado.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaResultado.Location = new System.Drawing.Point(38, 63);
            this.CajaResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CajaResultado.Name = "CajaResultado";
            this.CajaResultado.ReadOnly = true;
            this.CajaResultado.Size = new System.Drawing.Size(395, 34);
            this.CajaResultado.TabIndex = 0;
            this.CajaResultado.Text = "0";
            this.CajaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(34, 39);
            this.lblHistorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 21);
            this.lblHistorial.TabIndex = 1;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(35, 119);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(94, 94);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "C";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(136, 119);
            this.BtnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(195, 94);
            this.BtnBorrar.TabIndex = 3;
            this.BtnBorrar.Text = "<";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click_1);
            // 
            // BtnResta
            // 
            this.BtnResta.Location = new System.Drawing.Point(339, 322);
            this.BtnResta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnResta.Name = "BtnResta";
            this.BtnResta.Size = new System.Drawing.Size(94, 94);
            this.BtnResta.TabIndex = 4;
            this.BtnResta.Text = "-";
            this.BtnResta.UseVisualStyleBackColor = true;
            this.BtnResta.Click += new System.EventHandler(this.BtnResta_Click_1);
            // 
            // BtnSuma
            // 
            this.BtnSuma.Location = new System.Drawing.Point(339, 424);
            this.BtnSuma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(94, 94);
            this.BtnSuma.TabIndex = 8;
            this.BtnSuma.Text = "+";
            this.BtnSuma.UseVisualStyleBackColor = true;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click_1);
            // 
            // BtnResultado
            // 
            this.BtnResultado.Location = new System.Drawing.Point(339, 526);
            this.BtnResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnResultado.Name = "BtnResultado";
            this.BtnResultado.Size = new System.Drawing.Size(94, 94);
            this.BtnResultado.TabIndex = 9;
            this.BtnResultado.Text = "=";
            this.BtnResultado.UseVisualStyleBackColor = true;
            this.BtnResultado.Click += new System.EventHandler(this.BtnResultado_Click_1);
            // 
            // BtnPunto
            // 
            this.BtnPunto.Location = new System.Drawing.Point(238, 526);
            this.BtnPunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPunto.Name = "BtnPunto";
            this.BtnPunto.Size = new System.Drawing.Size(94, 94);
            this.BtnPunto.TabIndex = 10;
            this.BtnPunto.Text = ".";
            this.BtnPunto.UseVisualStyleBackColor = true;
            this.BtnPunto.Click += new System.EventHandler(this.BtnPunto_Click_1);
            // 
            // Btn0
            // 
            this.Btn0.Location = new System.Drawing.Point(36, 526);
            this.Btn0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(194, 94);
            this.Btn0.TabIndex = 11;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click_1);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(238, 427);
            this.Btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(94, 94);
            this.Btn3.TabIndex = 12;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click_1);
            // 
            // Btn2
            // 
            this.Btn2.Location = new System.Drawing.Point(136, 427);
            this.Btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(94, 94);
            this.Btn2.TabIndex = 13;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click_1);
            // 
            // Btn1
            // 
            this.Btn1.Location = new System.Drawing.Point(36, 424);
            this.Btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(94, 94);
            this.Btn1.TabIndex = 14;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click_1);
            // 
            // Btn6
            // 
            this.Btn6.Location = new System.Drawing.Point(238, 324);
            this.Btn6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(94, 94);
            this.Btn6.TabIndex = 15;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click_1);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(136, 324);
            this.Btn5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(94, 94);
            this.Btn5.TabIndex = 16;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click_1);
            // 
            // Btn4
            // 
            this.Btn4.Location = new System.Drawing.Point(36, 324);
            this.Btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(94, 94);
            this.Btn4.TabIndex = 17;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click_1);
            // 
            // BtnMultiplicacion
            // 
            this.BtnMultiplicacion.Location = new System.Drawing.Point(339, 222);
            this.BtnMultiplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMultiplicacion.Name = "BtnMultiplicacion";
            this.BtnMultiplicacion.Size = new System.Drawing.Size(94, 94);
            this.BtnMultiplicacion.TabIndex = 18;
            this.BtnMultiplicacion.Text = "X";
            this.BtnMultiplicacion.UseVisualStyleBackColor = true;
            this.BtnMultiplicacion.Click += new System.EventHandler(this.BtnMultiplicacion_Click_1);
            // 
            // Btn9
            // 
            this.Btn9.Location = new System.Drawing.Point(238, 222);
            this.Btn9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(94, 94);
            this.Btn9.TabIndex = 19;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click_1);
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(136, 222);
            this.Btn8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(94, 94);
            this.Btn8.TabIndex = 20;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click_1);
            // 
            // Btn7
            // 
            this.Btn7.Location = new System.Drawing.Point(35, 222);
            this.Btn7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(94, 94);
            this.Btn7.TabIndex = 21;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click_1);
            // 
            // BtnDivision
            // 
            this.BtnDivision.Location = new System.Drawing.Point(339, 119);
            this.BtnDivision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDivision.Name = "BtnDivision";
            this.BtnDivision.Size = new System.Drawing.Size(94, 94);
            this.BtnDivision.TabIndex = 22;
            this.BtnDivision.Text = "/";
            this.BtnDivision.UseVisualStyleBackColor = true;
            this.BtnDivision.Click += new System.EventHandler(this.BtnDivision_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 732);
            this.Controls.Add(this.BtnDivision);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnMultiplicacion);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnPunto);
            this.Controls.Add(this.BtnResultado);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.BtnResta);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.CajaResultado);
            this.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calcula2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CajaResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnResta;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Button BtnResultado;
        private System.Windows.Forms.Button BtnPunto;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnMultiplicacion;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDivision;
    }
}
