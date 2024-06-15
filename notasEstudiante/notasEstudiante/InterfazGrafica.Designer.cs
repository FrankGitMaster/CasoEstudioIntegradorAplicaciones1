//Desarrollado por Frank Aguilar Garzon y Juan Pablo Pinzon Delgado

namespace notasEstudiante
{
    partial class InterfazGrafica
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxEstudiante = new TextBox();
            textBoxCorte1 = new TextBox();
            textBoxCorte2 = new TextBox();
            textBoxCorte3 = new TextBox();
            labelEstudiante = new Label();
            labelNotaDefinitiva = new Label();
            textBoxDefinitiva = new TextBox();
            buttonCalcularDefinitiva = new Button();
            labelCorte1 = new Label();
            labelCorte2 = new Label();
            labelCorte3 = new Label();
            SuspendLayout();
            // 
            // textBoxEstudiante
            // 
            textBoxEstudiante.Font = new Font("Segoe UI", 12F);
            textBoxEstudiante.Location = new Point(30, 104);
            textBoxEstudiante.Name = "textBoxEstudiante";
            textBoxEstudiante.Size = new Size(151, 29);
            textBoxEstudiante.TabIndex = 0;
            textBoxEstudiante.TextChanged += textBox1_TextChanged;
            // 
            // textBoxCorte1
            // 
            textBoxCorte1.Font = new Font("Segoe UI", 12F);
            textBoxCorte1.Location = new Point(202, 104);
            textBoxCorte1.Name = "textBoxCorte1";
            textBoxCorte1.Size = new Size(172, 29);
            textBoxCorte1.TabIndex = 1;
            // 
            // textBoxCorte2
            // 
            textBoxCorte2.Font = new Font("Segoe UI", 12F);
            textBoxCorte2.ForeColor = SystemColors.WindowText;
            textBoxCorte2.Location = new Point(394, 104);
            textBoxCorte2.Name = "textBoxCorte2";
            textBoxCorte2.Size = new Size(172, 29);
            textBoxCorte2.TabIndex = 2;
            // 
            // textBoxCorte3
            // 
            textBoxCorte3.Font = new Font("Segoe UI", 12F);
            textBoxCorte3.Location = new Point(587, 104);
            textBoxCorte3.Name = "textBoxCorte3";
            textBoxCorte3.Size = new Size(172, 29);
            textBoxCorte3.TabIndex = 3;
            // 
            // labelEstudiante
            // 
            labelEstudiante.AutoSize = true;
            labelEstudiante.BackColor = Color.LightSeaGreen;
            labelEstudiante.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelEstudiante.ForeColor = Color.White;
            labelEstudiante.Location = new Point(30, 62);
            labelEstudiante.Name = "labelEstudiante";
            labelEstudiante.Padding = new Padding(30, 5, 30, 5);
            labelEstudiante.Size = new Size(151, 31);
            labelEstudiante.TabIndex = 4;
            labelEstudiante.Text = "Estudiante";
            labelEstudiante.Click += label1_Click;
            // 
            // labelNotaDefinitiva
            // 
            labelNotaDefinitiva.AutoSize = true;
            labelNotaDefinitiva.BackColor = Color.LightSeaGreen;
            labelNotaDefinitiva.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNotaDefinitiva.ForeColor = Color.White;
            labelNotaDefinitiva.Location = new Point(188, 222);
            labelNotaDefinitiva.Name = "labelNotaDefinitiva";
            labelNotaDefinitiva.Padding = new Padding(30, 5, 30, 5);
            labelNotaDefinitiva.Size = new Size(186, 31);
            labelNotaDefinitiva.TabIndex = 8;
            labelNotaDefinitiva.Text = "Nota definitiva";
            // 
            // textBoxDefinitiva
            // 
            textBoxDefinitiva.Font = new Font("Segoe UI", 12F);
            textBoxDefinitiva.Location = new Point(394, 224);
            textBoxDefinitiva.Name = "textBoxDefinitiva";
            textBoxDefinitiva.Size = new Size(146, 29);
            textBoxDefinitiva.TabIndex = 9;
            // 
            // buttonCalcularDefinitiva
            // 
            buttonCalcularDefinitiva.BackColor = Color.Honeydew;
            buttonCalcularDefinitiva.Font = new Font("Segoe UI", 12F);
            buttonCalcularDefinitiva.Location = new Point(310, 164);
            buttonCalcularDefinitiva.Name = "buttonCalcularDefinitiva";
            buttonCalcularDefinitiva.Size = new Size(147, 34);
            buttonCalcularDefinitiva.TabIndex = 10;
            buttonCalcularDefinitiva.Text = "Calcular definitiva";
            buttonCalcularDefinitiva.UseVisualStyleBackColor = false;
            buttonCalcularDefinitiva.Click += buttonCalcularDefinitiva_Click;
            // 
            // labelCorte1
            // 
            labelCorte1.AutoSize = true;
            labelCorte1.BackColor = Color.LightSeaGreen;
            labelCorte1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCorte1.ForeColor = Color.White;
            labelCorte1.Location = new Point(202, 62);
            labelCorte1.Name = "labelCorte1";
            labelCorte1.Padding = new Padding(30, 5, 30, 5);
            labelCorte1.Size = new Size(172, 31);
            labelCorte1.TabIndex = 11;
            labelCorte1.Text = "Corte 1 (35%)";
            labelCorte1.Click += label6_Click;
            // 
            // labelCorte2
            // 
            labelCorte2.AutoSize = true;
            labelCorte2.BackColor = Color.LightSeaGreen;
            labelCorte2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCorte2.ForeColor = Color.White;
            labelCorte2.Location = new Point(394, 62);
            labelCorte2.Name = "labelCorte2";
            labelCorte2.Padding = new Padding(30, 5, 30, 5);
            labelCorte2.Size = new Size(172, 31);
            labelCorte2.TabIndex = 12;
            labelCorte2.Text = "Corte 2 (35%)";
            // 
            // labelCorte3
            // 
            labelCorte3.AutoSize = true;
            labelCorte3.BackColor = Color.LightSeaGreen;
            labelCorte3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCorte3.ForeColor = Color.White;
            labelCorte3.Location = new Point(587, 62);
            labelCorte3.Name = "labelCorte3";
            labelCorte3.Padding = new Padding(30, 5, 30, 5);
            labelCorte3.Size = new Size(172, 31);
            labelCorte3.TabIndex = 13;
            labelCorte3.Text = "Corte 3 (30%)";
            // 
            // InterfazGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelCorte3);
            Controls.Add(labelCorte2);
            Controls.Add(labelCorte1);
            Controls.Add(buttonCalcularDefinitiva);
            Controls.Add(textBoxDefinitiva);
            Controls.Add(labelNotaDefinitiva);
            Controls.Add(labelEstudiante);
            Controls.Add(textBoxCorte3);
            Controls.Add(textBoxCorte2);
            Controls.Add(textBoxCorte1);
            Controls.Add(textBoxEstudiante);
            Name = "InterfazGrafica";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxEstudiante;
        private TextBox textBoxCorte1;
        private TextBox textBoxCorte2;
        private TextBox textBoxCorte3;
        private Label labelEstudiante;
        private Label labelNotaDefinitiva;
        private TextBox textBoxDefinitiva;
        private Button buttonCalcularDefinitiva;
        private Label labelCorte1;
        private Label labelCorte2;
        private Label labelCorte3;
    }
}
